-- Created by JB "Noors" Sarrazin 2014-08-21
-- Based on : 
--Normal Thief 1.0 By Mauricio B. G. (mbg@southlogic.com)
--SlideNormalThief By Slide Ltd 2010-06-26 (contact@slidelondon.com)

-- macroScript NoorsNormalThief
-- category:"Noors"
-- buttontext:"NoorsNormalThief"
-- toolTip:"NoorsNormalThief"
--icon:#()
(
--FUNCTIONS
fn projectNormal sObj t1Obj =
(	
-----------------
start = timestamp()
windows.sendmessage (windows.getmaxhwnd()) 0x000B 0 1
max modify mode
	
--set source	
select sObj	

----set normal modifier on source object	
msNormals = Edit_Normals ()
msNormals.displayLength = 0
addmodifier sObj msNormals

s_NumNorm = msNormals.GetNumNormals()
msNormals.SetSelection #{1..s_NumNorm}
msNormals.Unify()
msNormals.MakeExplicit()
--cache functions
s_Convert = msNormals.ConvertVertexSelection 
s_NumVert = msNormals.GetNumVertices()
s_Setnormal = msNormals.Setnormal 
s_GetVert = msNormals.GetVertex
----get all source object vertex coordinates
refTransform = sObj.objecttransform
start = timestamp()
vCoords = for i = 1 to s_NumVert collect (s_GetVert i)	* refTransform
end = timestamp()
format "took % seconds\n" ((end-start)/1000.0)
	
--set target
tri_tObj = snapshotasmesh t1Obj
tObj = editable_mesh()
tObj.mesh = tri_tObj
select tObj
----set normal modifier on target object	
mtNormals = Edit_Normals ()
mtNormals.displayLength = 0
addmodifier tObj mtNormals
--cache functions
t_Convert = mtNormals.ConvertVertexSelection 
t_GetNormal = mtNormals.Getnormal 
t_NumVert = mtNormals.GetNumVertices()

normalArray = #()
normalArray[t_NumVert] = 0
closestVertArray = #()
closestVertArray[s_NumVert] = 0
	
--collect all normals of target object in normalArray
for i = 1 to t_NumVert do
(	
	tnormalIDArray = #{}
	t_Vert = #{i}
	t_Convert &t_Vert &tnormalIDArray 
	tnormID = (tnormalIDArray as array)[1]
	n = t_GetNormal tnormID
	normalArray[i] = n
)

--for each vertex of source object, collect the closest point on target object in closestVertArray
mpi = MeshProjIntersect()
mpi.setNode tObj
mpi.build()

for i =1 to s_NumVert do 
(
	refPos = vCoords[i]
	check = mpi.closestFace refPos doubleSided:true
	--if hit succeed
	if check == true then
	(
		closestVert = 0
		closestPoint = mpi.getHitPos()
		closestFace = mpi.GetHitFace()
		--zero based index
		closestFace+=1

		d = 10000000.0 --max distance to look for
		vID = getFace tObj closestFace
		vv = #(vID.x,vID.y,vID.z)
		getVertPos = meshop.getVert
		
		for v in vv do
		(
			curDist = distance (getVertPos tObj v) closestPoint
			if curDist < d do 
			(
				closestVert = v
				d = curDist
			)
		)	
		closestVertArray[i] = closestVert
	)
	--if hit fails
	else 
	(
		closestVertArray[i] = 1 
		format "Warning : fail on source vertex %\n" i
	)
)

--set normals on source obj
select sObj
disableRefMsgs()
for i =1 to s_NumVert do 
(
	s_normalIDArray = #{}
	s_Convert #{i} s_normalIDArray
	s_normID = (s_normalIDArray as array)[1]
	closestVert = closestVertArray[i] 
	s_norm = normalArray[closestVert]
	s_Setnormal s_normID s_norm
)
enableRefMsgs()

--clean scene
delete tObj
mpi.Free()

windows.sendmessage (windows.getmaxhwnd()) 0x000B 1 1
--force UI refresh
update sObj	
redrawViews() 	
max create mode
max modify mode
	
end = timestamp()
format "took % seconds\n" ((end-start)/1000.0)
)

--UI
rollout NoorsNormalThief " Noors NormalThief" width:146
	(
		group "Steal normals from"
		(
			pickbutton refPick "Reference Object" width:120 align:#left
		)
		group "Give normals to"
		(
			pickbutton objPick "Target Object" width:120 align:#left
		)
		group "Steal"
		(
			button sntSteal "Steal" width:120 align:#left
		)

		on refPick picked refmesh do
		(
			if (refmesh != undefined) do
				 refPick.text = refmesh.name
		)
		
		on objPick picked objmesh do
		(
			if (objmesh != undefined) do
				 objPick.text = objmesh.name
		)

		on sntSteal pressed  do
		(	
			obj = objPick.object 
			ref = refPick.object
			if (obj != undefined) and (ref != undefined) then 
			(
				if (superclassof obj == geometryclass) and (superclassof ref == geometryclass) then
				(
					projectNormal objPick.object refPick.object
					/*try (projectNormal objPick.object refPick.object)
					catch 
					(
						windows.sendmessage (windows.getmaxhwnd()) 0x000B 1 1
						messageBox "Sorry, script has encountered an error." title:"Oops !"
					)*/
				)
				else(messageBox "Please set valid geometry objects." title:"Oops !" )
			)
			else(messageBox "Please set target and source objects." title:"Oops !" )
		)
	)
	
try(destroyDialog NoorsNormalThief)catch()
	createDialog NoorsNormalThief style:#(#style_toolwindow, #style_sysmenu) 
)