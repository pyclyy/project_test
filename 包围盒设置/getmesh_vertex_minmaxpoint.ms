

---获取mesh 顶点最大 和最小的点   
--- onoff = true   最大点 最小点
--- onoff = false  是返回长宽高 点 

fn getmesh_vertex_minmaxpoint nodes  vertexs  onoff    = (
	minx =99999999999
	miny =99999999999
	minz =99999999999
	maxx=0
	maxy=0
	maxz=0 
	
	obj = nodes.mesh 
	---obj = snapshotAsMesh nodes 
	
	for i in vertexs  do (
		
		newpoint =  getVert   obj   i 
		if newpoint[1] < minx then  minx = newpoint[1]  
		if newpoint[2] < miny then  miny = newpoint[2]
		if newpoint[3] < minz then  minz = newpoint[3]
		
		
		if newpoint[1] > maxx then  maxx = newpoint[1]
		if newpoint[2] > maxy then  maxy = newpoint[2]
		if newpoint[3] > maxz then  maxz = newpoint[3]
			
	)
	if onoff ==true then(
	return  #([minx,miny,minz],[maxx,maxy,maxz])
	)else (
		return  [(maxx-minx),(maxy-miny),(maxz-minz)]
	)

	
)