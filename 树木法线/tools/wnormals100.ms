-- WEIGHTEDNORMALS.MS

-- Computes Weighted Vertex Normals
-- by Martijn Buijs, 2014
-- www.bytehazard.com

-- 3DSMAX bugs encountered:
-- 1) .modifiers[#Edit_Normals] doesn't work on renamed modifiers for no
--     apparant reason
-- 2) We can only ever modify the topmost Edit_Normals modifier, even if we
--    properly access it through its handle. So if there's another Edit_Normals
--    modifier on the stack, we add a new modifier, so the user won't have his
--    changes overwritten.
-- 3) During testing, the script twice crashed on some geometry lacking
--    smoothing groups. Unable to reproduce.

global wnmodname = "Weighted Normals"


-- returns angle between two vectors
fn AngleBetweenVectors v1 v2 =
(
 return (acos (dot (normalize v1) (normalize v2) ) )
)


-- get weighted normals modifier
fn wnGetModifier obj =
(
 for i=1 to obj.modifiers.count do
 (
  local mf = obj.modifiers[i]
  if (classof mf) == Edit_Normals do
  (
   if (mf.name == wnmodname) then (
    return mf
   ) else (
    return undefined
   )
  )
 )
 return undefined
)


-- generates weighted normals
fn GenWeightedNormals obj =
(
 -- filter
 if (superClassOf obj) != GeometryClass do return false
 
 -- add mesh modifier
 if (classOf obj) != Editable_Mesh do
 (
  addModifier obj (Edit_Mesh())
 )
 
 -- detect existing modifier
 local mf = wnGetModifier obj
 
 -- modifier not found, create one
 if mf == undefined do
 (
  addModifier obj (Edit_Normals())
  mf = obj.modifiers[#Edit_Normals]
  mf.name = wnmodname
 )
 
 -- workaround for 3dsmax bug
 select obj
 max modify mode
  
 -- build face area array
 local facearea = #()
 facearea.count = obj.numFaces
 for i=1 to obj.numFaces do
 (
  facearea[i] = (meshop.getFaceArea obj i)
 )
 
 -- build face angle array
 local faceangle = #()
 faceangle.count = obj.numFaces
 for i=1 to obj.numFaces do
 (
  local f = getFace obj i
  local v1 = getVert obj f[1]
  local v2 = getVert obj f[2]
  local v3 = getVert obj f[3]
  local a1 = AngleBetweenVectors (v2-v1) (v3-v1) -- todo: optimize
  local a2 = AngleBetweenVectors (v1-v2) (v3-v2)
  local a3 = AngleBetweenVectors (v1-v3) (v2-v3)
  faceangle[i] = [a1,a2,a3]
 )
 
 -- get number of normals
 local normNum = mf.GetNumNormals()
 
 -- allocate array
 local norms = #()
 norms.count = normNum
 for i=1 to normNum do
 (
  norms[i] = [0,0,0]
 )
 
 -- loop faces
 for i=1 to obj.numFaces do
 (
  -- get face normal
  in coordsys local n = getFaceNormal obj i
  
  -- accumulate
  for j=1 to 3 do
  (
   local id = mf.GetNormalID i j
   norms[id] = norms[id] + (n * facearea[i] * faceangle[i][j])
  )
 )
 
 -- set normals
 for i=1 to normNum do
 (
  -- make explicit
  mf.SetNormalExplicit i explicit:true
  
  -- set normal vector
  mf.SetNormal i (normalize norms[i])
 )
)


--- GUI ------------------------------------------------------------------------


-- close existing floater
if WeightedNormals != undefined do
(
 closeRolloutFloater WeightedNormals
)

-- create floater
WeightedNormals = newRolloutFloater "Weighted Normals" 180 150


-- generate rollout
rollout rWNGenerate "Weighted Normals"
(
 button cmdCreate "Generate" width:140
 
 on cmdCreate pressed do
 (
  -- copy selection (can't copy arrays in 3dsmax)
  local sel = #()
  for i=1 to selection.count do
  (
   sel[i] = selection[i]
  )
  
  -- create selection list
  for i=1 to sel.count do
  (
   GenWeightedNormals sel[i]
  )
  
  -- restore selection
  selection = sel
 )
)
addRollout rWNGenerate WeightedNormals


-- about rollout
rollout rWNAbout "About"
(
 label lab1 "Weighted Normals 1.0.0"
 label lab2 "by Martijn Buijs"
 label lab3 "www.bytehazard.com"
)
addRollout rWNAbout WeightedNormals


-- END OF FILE