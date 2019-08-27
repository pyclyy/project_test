
rollout SetPlantsNormal "Plants Normal Editor" width:220 height:300
(  
	pickButton objbtn "Pick Object" pos:[20,25] width:85 height:30 --align:#left
	label lbl1 "Pick an Object to Edit" pos:[115,25] width:85 height:30 enabled:true
	pickButton pickbtn "Pick Pivot" pos:[20,60] width:85 height:30 --align:#left
	label lbl2 "Pick Pivot Object to Project" pos:[115,60] width:85 height:30 enabled:true
 	button setbtn "Set Normals" pos:[20,130] width:180 height:50
	groupBox grp1 "Set All VertexNormals Pivot" pos:[5,5] width:210 height:100 toolTip:"n/a"
	groupBox grp3 "SetNormals" pos:[5,110] width:210 height:80 toolTip:"n/a"
	label lbl3 ">>>====================<<<" pos:[10,210] width:200 height:15 enabled:true
	label lbl4 "YangXiguang" pos:[80,230] width:200 height:15 enabled:true 
	label lbl5 "CYOU-Engine-TA" pos:[70,250] width:200 height:15 enabled:true
	label lbl6 "Project Object to Pivot" pos:[60,270] width:200 height:15 enabled:true
	global objp = undefined 
	global objm = undefined 
	
	on objbtn picked obj do
 (	
	objm = convertToMesh obj

 )
	on pickbtn picked obj do
 (
	objp = convertToMesh obj

 )	
	on setbtn pressed do
 (
	
	n = meshop.getNumVerts objm
	for v = objm.numVerts to 1 by -1 do
    (
		ppos=meshop.getVert objp v
		mpos = meshop.getVert objm v
		normal=mpos-ppos
	    setNormal objm v normal				
	)
    
  )
 

)


CreateDialog  SetPlantsNormal