-- OPTIMIZED WEIGHTED NORMALS

-- Computes Weighted Vertex Normals
-- original idea by Martijn Buijs, 2014
-- www.bytehazard.com
-- updated and optimized version by Adam Wrotek
-- www.scgstudio.net
global OWNGenerate, O_W_N
(
fn generate_normals_from obj =
(
start = timestamp()

addModifier obj (Edit_Mesh())
faceSel = #{1..obj.numFaces} as array
local facearea = #()
local faceangle = #()
local _face_normal = #()
 local norms = #()
local norms_id = #()
-- all data taken from mesh topology are collected in one loop
 for i = 1 to faceSel.count do
 (
	 
	facearea[i] = ( meshop.getFaceArea obj faceSel[i] )
	local f = getFace obj faceSel[i]
	local v1 = getVert obj f[1]
	local v2 = getVert obj f[2]
	local v3 = getVert obj f[3]
	 
	local a1 = acos (dot (normalize (v2-v1)) (normalize (v3-v1)))
	local a2 = acos (dot (normalize (v1-v2)) (normalize (v3-v2))) 
	local a3 = acos (dot (normalize (v1-v3)) (normalize (v2-v3))) 
	faceangle[i] = [a1,a2,a3]
	in coordsys local _face_normal[i] = getFaceNormal obj faceSel[i]	
 )
 -- once they are in varialbles
 -- let's add modifier
  addModifier obj (Edit_Normals())  
  mf = obj.modifiers[#Edit_Normals]
 -- collecting all normals ( including normals comming from smooth groups )
 local normNum = mf.GetNumNormals()
 for n = 1 to normNum do norms[n] = [0,0,0] -- assign 'dummy' normal direction to make an array of normals
 for i = 1 to faceSel.count do -- for each face 
 (
	for j = 1 to 3 do -- go through every vertex
	(
		local id = mf.GetNormalID faceSel[i] j --get normal for this vertex
		-- abracadabra
		-- means calculate normal length [x,y,x] values for every normal, the bigger numbers the longer normal is
		-- if normal is appearing more than once "norms[id] = norms[id] + ..."
		-- it means its values will increase with each calculation making it even longer
		norms[id] = norms[id] + (_face_normal[i] * facearea[i] * faceangle[i][j])
		-- add calculated normal to another array
		-- applying calculated normal directions is faster than gathering whole data again
		appendifunique norms_id id -- every normal will be added only once
	)
)
for n = 1 to norms_id.count do -- go through every calculated normal
(	
	 -- make it explicit ( green colored so it will survive after modifier collapse / convert or in editable poly )
	mf.SetNormalExplicit norms_id[n] explicit:true
	-- apply normalized normal, normalized means, its length will be equal 1
	-- final normal direction will be determined by reduced every [z,y,z] value to
	-- a moment where all three values added together will be equal 1
	-- normalize [-191.165,-14.3503,1138.53] = [-0.165574,-0.0124293,0.986119]
	-- so normal direction will be mostly z-up 
	-- (1 means 100% vertical direction up so other values will have to be 0 like [0,0,1]) and slightly x left and y left
	-- uncomment line below to see the difference
	-- format "normal id = % normal vector = % normalized normal vector = %\n" norms_id[n] norms[norms_id[n]] (normalize norms[norms_id[n]])
	mf.SetNormal norms_id[n] (normalize norms[norms_id[n]])
)
end = timestamp()	
OWNGenerate.stats.text = "generating normals took : " + ((end-start)/1000.0) as string + " s"
-- if "Convert to Editable Poly" is activated
if OWNGenerate.to_poly.checked then
(
	addModifier obj (Poly_Select ()) -- add polyselect modifier
	maxOps.CollapseNodeTo obj 1 off -- collapse stack to editable poly
	-- why not just converttopoly obj ??
	-- 1st approach is instance friendly :)
	-- while converttopoly is breaking any connections between instances.
)
)
--- GUI ------------------------------------------------------------------------
-- close existing floater
if O_W_N != undefined do
(
 closeRolloutFloater O_W_N
)
-- create floater

O_W_N = newRolloutFloater "OWN" 200 240
-- generate rollout
rollout OWNGenerate "Weighted Normals"
(
 button cmdCreate "Generate" pos:[26,4] width:140 height:20
 checkbutton to_poly "Convert to Editable Poly" pos:[26,28] width:140 height:20
label stats ""  pos:[4,54] width:190 
 on cmdCreate pressed do
 (

  local sel = #()
  for i=1 to selection.count do sel[i] = selection[i]  -- copy selection (can't copy arrays in 3dsmax)
  for i=1 to sel.count do	generate_normals_from sel[i]  -- create selection list and generate normals for each selected object
  selection = sel  -- restore selection
 )
)
addRollout OWNGenerate O_W_N
rollout OWNAbout "About"
(
 label lab1 "Optimized Weighted Normals 1.5.0"
 label lab2 "Original idea by Martijn Buijs"
 label lab3 "www.bytehazard.com"
 label lab4 "Optimized version by Adam Wrotek"
 label lab5 "www.scgstudio.ne t"	
)
addRollout OWNAbout O_W_N

)
-- END OF FILE
