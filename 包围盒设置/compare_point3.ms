

--- 数学运算 

--- -- 根据point3 来产生box数字 
----onoff = true 返回最大最小 、 反之 返回对应的长宽高
--- onoff = false 是特殊处理 z最小是0 

fn  compare_point3  point3array onoff  = (
	minx =99999999999
	miny =99999999999
	minz =99999999999
	maxx=0
	maxy=0
	maxz=0 
	
	for i in point3array   do (
		
		newpoint =    i 
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
		---- 由于该函主要是处理 包围盒的情况， 所以要求是 z 不能小于0 
		if minz < 0 then  minz = 0 
		
		return  [(maxx-minx),(maxy-miny),(maxz-minz)]
	)
	
	
)