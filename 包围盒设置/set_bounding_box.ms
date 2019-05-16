
 ---制作包围盒弓箭
---- gett mesh 

---- getVertSelection  $  ( $.modifiers[1]) 
---- 操作时候 利用mesh selection 来完成这部分的操作 
---- 然后利用   trimesh 来处理

---- 利用mesh 来完成顶点采取部分
-- ceshi = $.mesh 
-- getVert   ceshi  1 
-- ceshi
 
 
 pyc_inscript   "tstring"
 pyc_inscript  "ling_layer_controller"
 pyc_inscript  "ling_openmax"
 pyc_inscript  "max_synchronous_link"
 pyc_inscript  "base\\ling_xml_data"
 
 pyc_inscript  "base\\getmesh_vertex_minmaxpoint" 
 pyc_inscript    "a\\setAnimation_range"
 pyc_inscript "base\\compare_point3"
 pyc_inscript "check_a\\ling_check_max_chinfor"
 
 
rollout set_bounding_box     "设置包围盒(角色有蒙皮)(tanpei20190515)" width:300 height:700
(
	
	label   lab        "拖拽max文件到列表中:" across:1 offset:[-80,0]
	dotNetControl  listmax "system.Windows.Forms.ListBox"  height:300 
	
	
	
	button  addmeshvertex   "加入检查的点(模型要求加入mesh select )"  across:1  offset:[0,-30] width:280  height:27   
	listbox  checklist  "要检查的模型:"  height:7 across:1
	
	button  clalist      "清空检查列表"  across:1  width:280 height:20  
	
	button  checkrun     "检查并设置包围盒"  across:1  width:280 height:35 
	--- 设置info 节点
	label   lab3        "拖拽需要设置info 的max文件:" across:1 offset:[-50,0]
	dotNetControl  infomax   "system.Windows.Forms.ListBox"  height:50   width:280 
	
	button  setinfo     "循环max文件-设置info信息"   across:1  width:280 height:35  offset:[0,-20]
	
	
	label    lab1    "针对动画逐帧检查." across:1 offset:[-100., 0]
	
	label    lab2    "tanpei:20190515" across:1 offset:[-100., 0]
	
	local  xmlpath  = scriptpath()+"\\base\\xmlbox.xml"
	
	
	fn getitems = (
		bi = listmax.items
		cu= listmax.items.count 
		tem = #()
		if cu> 0 then (
			for  i in 0 to (cu-1) do (
				append tem (bi.item(i))
			)				
			
		)
		
		return tem  
	)
	fn getitems_one  = (
		bi = infomax.items
		cu= infomax.items.count 
		tem = #()
		if cu> 0 then (
			for  i in 0 to (cu-1) do (
				append tem (bi.item(i))
			)				
			
		)
		
		return tem  
	)
	
	
	
	fn checkonoff  = (
		checkname1 = tstring(basename.text)
		list = getitems()
		onoff =false 
		index = 0 
		ioo =0 
		for i  in list do (
			ioo+=1 
			filename = getfilenamefile i 
			if filename == checkname1 then (
				onoff =true 
				index = ioo 
			)
		)
		-- 确定是否有对应max文件 确定索引id 
		return  #(onoff , index )
		
	)
	
	--- 根据选择返回实例化的对象
	fn getmeshselect  nodes   = (
		midcount  = nodes.modifiers.count 
		
		key = #()
		val =#()
		if midcount > 0 then (
			if classof nodes.modifiers[1] == Mesh_Select then (
				getv = ( getVertSelection  nodes  ( nodes.modifiers[1]) ) as array 
				
				append  key  nodes.name 
				append  val  (with printAllElements on getv  as string )
				
				
			)
		)
		
		return  #(key , val )
	)
	fn  xie  key val = (
		info= getnodebyname ("info")
		if info ==undefined then ( setListenerSelText "info 为假\n")else(
		setUserProp info key val 
		)
	)
	
	
	----写逻辑 == 
	on addmeshvertex  pressed do (
		t = (selection  as array )
		diskey = #()
		if t.count >0 then (

			keyval = getmeshselect  t[1] 
			
			--- 加入xml 
			xml = ling_xml_data()
			xml.init()
			isdit =  xml.load  xmlpath 
			if isdit == false then (
				diskey = keyval[1] 
				xml.addelm  "node"  keyval[1] keyval[2]
				xml.savexml  xmlpath 
				
			)else (
				
				if (isdit.getvalues()).count != 0 then (
				tmkey =(isdit.getvalues())[1][1]
				temval = (isdit.getvalues())[1][2]
				)else (
					tmkey  =#()
					temval =#()
				)
				
				key = tmkey + keyval[1]
				val = temval + keyval[2]
				xml.init()
				diskey = key 
				xml.addelm  "node"  key  val 
				xml.savexml  xmlpath 
			)
		)
		----设置 
		checklist.items= diskey 
		
	)
	
	on checkrun pressed do (
		if (getitems()).count>0 then (
			---- 检查max文件夹
			for i in  (getitems()) do (
				ling_openmax i 
				point3_array = #()
				
				setAnimation_range()
				xml = ling_xml_data()
				xml.init()
				isdit =  xml.load  xmlpath 
				if isdit != false then (
					if (isdit.getvalues()).count != 0 then (
					tmkey =(isdit.getvalues())[1][1]
					temval = (isdit.getvalues())[1][2][1] --- 去除第一个字符串 
					
						for objnode in  tmkey do (	
						
							isnode = getnodebyname  objnode
							if isnode != undefined then (
								--- mei 计算 
								vertarray = execute temval 
								 st = (int)animationRange.start
								 ed = (int)animationRange.end
								
								 for i in st to ed do (
									 slidertime =i 
									 --- get 模型pos  
									 onefamepoint3 =  getmesh_vertex_minmaxpoint isnode   vertarray  true  
									   point3_array+= onefamepoint3 
								 )	
							)
						)	
					)
				)
				
				--- 一个max文件计算完成以后，计算最大盒子， 设置box 保存 
				minmax =  compare_point3 point3_array true 
				if minmax[1][3] <0 then 	(
					--- min小于0 大的也需要下降
					minmax[1][3] =0 
					
				)
				
				lenght_width_height	 = [ (minmax[2][1]-minmax[1][1]) ,(minmax[2][2]-minmax[1][2]),(minmax[2][3]-minmax[1][3])]
				
				movex = (minmax[2][1]-minmax[1][1])/2 +minmax[1][1] 
				movey = (minmax[2][2]-minmax[1][2])/2+minmax[1][2] 
				
				gnode =  getnodebyname "bbox"
				if gnode == undefined then (
				bbox = box ()
				bbox.name  = "bbox"
				bbox.length = lenght_width_height[2]
				bbox.width = lenght_width_height[1]
				bbox.height = lenght_width_height[3]
					
				--- 创建的包围盒要进行位置移动 
				move bbox [movex ,movey ,0]
				bbox.xray =true 
					
					
				)else (
					delete  gnode 
				bbox = box ()
				bbox.name  = "bbox"
				bbox.length = lenght_width_height[2]
				bbox.width = lenght_width_height[1]
				bbox.height = lenght_width_height[3]
				move bbox [movex ,movey ,0]
				bbox.xray =true 

				)
				
				saveMaxFile  (maxfilepath + maxfilename)
				 
			)
			
			
		)
	)
	
	on  setinfo pressed do (
		--- 循环文件设置info 信息  
		if (getitems()).count>0 then (
			---- 检查max文件夹
			 totopoint3 =#()
			for i in  (getitems()) do (
				ling_openmax i 
				ai = getnodebyname "bbox"
				if ai != undefined then (
					append totopoint3  ai.min  
					append totopoint3  ai.max 
					
				)else (
					setListenerSelText  ( maxfilename + "::没有设置包围盒") 
				)
				
				
			)
			---- 设置大小 
			

			--最大最小或缺， 设置 #([],[])
			getmax  = getitems_one()
			if getmax.count > 0 then (
				for i in  getmax do (
					ling_openmax i 
					max_synchronous_link() --- 设置info
					---- 处理东西
					minmax =  compare_point3 totopoint3 true 	
					m =  minmax[2]
					n =  minmax[1]
					chinfor =ling_check_max_chinfor()
					key = chinfor.bb
					
					val = "("+n[1] as string +","+n[2] as string +","+n[3] as string +")"+","+ "("+m[1] as string +","+m[2] as string +","+m[3] as string +")"
					xie  key val
							
				)
				
			)
			
			
		)
		
	)

	
	on  clalist pressed do (
		--- shezhi xml 位空 
			xml = ling_xml_data()
			xml.init()
			xml.savexml  xmlpath 
			checklist.items =#()
	)

	
	on listmax  DragEnter arg do (
		
		-- 写格式
		filetype = dotnetclass "System.Windows.Forms.DataFormats"
		filet = filetype.FileDrop 
		
		ftt = arg.Data.GetDataPresent (filet)
		--print ftt 
		ef = dotnetclass "System.Windows.Forms.DragDropEffects"
		
		if  ftt then (
			
			arg.Effect = ef.link 
		)else (
			arg.Effect = ef.None 
		)
	)
	on infomax   DragEnter arg do (
		
		-- 写格式
		filetype = dotnetclass "System.Windows.Forms.DataFormats"
		filet = filetype.FileDrop 
		
		ftt = arg.Data.GetDataPresent (filet)
		--print ftt 
		ef = dotnetclass "System.Windows.Forms.DragDropEffects"
		
		if  ftt then (
			
			arg.Effect = ef.link 
		)else (
			arg.Effect = ef.None 
		)
	)
	
	
	
	
	on listmax DragDrop  arg do (
		
	listmax.items.clear()
	filetype = dotnetclass "System.Windows.Forms.DataFormats"
	filet = filetype.FileDrop 
	p = arg.Data.GetData (filet)
	totolist = #()
		for i in p do (
			kn= tolower ( getfilenametype i )
			if kn ==".max"then (
				--print kn 
				---append totolist ( i.tostrintg()) 
				listmax.items.add (i )
			)
		)
	--- 加入到对应的列表中 	
	)
	on infomax  DragDrop  arg do (
		
	infomax.items.clear()
	filetype = dotnetclass "System.Windows.Forms.DataFormats"
	filet = filetype.FileDrop 
	p = arg.Data.GetData (filet)
	totolist = #()
		for i in p do (
			kn= tolower ( getfilenametype i )
			if kn ==".max"then (
				--print kn 
				---append totolist ( i.tostrintg()) 
				infomax.items.add (i )
			)
		)
	--- 加入到对应的列表中 	
	)
	
	
	
	

	on runbutton pressed do (
		--- 处理选择逻辑

	)	
	
	on set_bounding_box open do (
		obj = dotnetclass  "System.Drawing.Color"  
		graycolor = obj.FromArgb  98 119 128 
		listmax.backColor =graycolor
		infomax.backColor = graycolor 
		sy = dotnetclass  "System.Windows.Forms.BorderStyle"  
		syb = sy.FixedSingle
		listmax.BorderStyle = syb 
		infomax.BorderStyle = syb 
		listmax.Enabled = true
		infomax.enabled =true 
		listmax.AllowDrop =true 
		infomax.AllowDrop = true 
		listmax.Horizontalscrollbar =true 
		
		
		xml = ling_xml_data()
		xml.init()
		isdit =  xml.load  xmlpath 
		if isdit == false then (
			diskey = keyval[1] 
			xml.addelm  "node"  keyval[1] keyval[2]
			xml.savexml  xmlpath 
			
		)else (
			
			if (isdit.getvalues()).count != 0 then (
			tmkey =(isdit.getvalues())[1][1]
			temval = (isdit.getvalues())[1][2]
			)else (
				tmkey  =#()
				temval =#()
			)
			
			key = tmkey 
			val = temval 
			diskey = key 
			checklist.items = diskey
		)
		
		
	)
	
	
	
)
createdialog set_bounding_box 