
--- 对于层的划分这里做一个工具进行不就，之后需要对齐进行查找操作 。 
--- 打开需检查层数量-- 移动层，节点， 按照标准来简历层等操作 

struct ling_layer_controller (
	--layer 是从 0 开始的 
	fn  getlayernanes = (
		temnum = LayerManager.count 
		con = #()
		for i  in  0 to temnum-1 do (
			append con  ((LayerManager.getLayer i ).name )
		)
		con 
	),
	fn step_cl = (
		temnum = LayerManager.count 
		--因为有层级关系单独产生 
			while  temnum >1 do  (
				temname = (LayerManager.getLayer (temnum-1) ).name 
				LayerManager.deleteLayerByName temname 
				temnum = LayerManager.count 
			)

	),
	fn clearlayer   = (
		--- 所有节点到0 中 移动到0 中 
		temnum = LayerManager.count 
		baselay = (LayerManager.getLayer 0 )
		(LayerManager.getLayer 0 ).current= true 
		
		
		for i in 0 to temnum-1 do (
			tembbv = #()
			(LayerManager.getLayer i ).nodes &tembbv 
			
			if  tembbv.count >0 then (
				
				for c in tembbv do (	
					baselay.addnode c 
				)
				--LayerManager.deleteLayerByName temname 
				
			)
		)
		-- 这里的函数搞了一个小时 主要是对于数组删除出现实时删除会出现 扩初问题，所以要特殊处理 
		step_cl()
		
	),
	fn  getlayertostandard = (
		totolist = #()
		---返回key value 关系， 标准化然后处理  返回名称处理  
		-- onoff 是记录层的显示于开关在同步时候有用 20181210 
		struct  ojb (key="" , val = #(),onoff =true)
		temnum = LayerManager.count
		for i in 0 to temnum-1 do  (
			key = (LayerManager.getLayer (i) ).name 
			tembbv = #()
			(LayerManager.getLayer i ).nodes &tembbv 
			totoname =#()
			for cc in tembbv do (
				append totoname cc.name 
			)
			val = totoname 
			onoff = (LayerManager.getLayer (i) ).on 
			
			bj = ojb  key val onoff 
			append totolist bj 
		)
			
		return totolist 
		
	),
	fn check_children = (
		temnum = LayerManager.count
		onoff =false 
		for i in 0 to temnum-1 do  (
			key = (LayerManager.getLayer (i) ). getNumChildren()
			if key >0 then (
				onoff = true 
				exit 
			)
			
		)
		return  onoff
	),
	-- 根据创建的具体需求来完成先关操作 
	fn  setlayer  getlayertostandardst = (
		errorarray = #() 
		
		if getlayertostandardst.count >0 then (
			
			bba =getlayertostandardst 
			for i in  bba do (
				
				k= i.key
				onoff = i.onoff 			
				
				if k =="0" then (
					(LayerManager.getLayer (0) ).on = onoff 
					continue
				)					
				base = LayerManager.newLayerFromName k
				base.on = onoff 
				connodename = i.val 
				for i in  connodename do (
					nodes = getnodebyname i 
					if nodes !=undefined then (
						base.addnode nodes 
					)else (
						totostring = "模板数据::"+k 
						--- 改节点不存在 处理 
						totostring +="::"+i +"::" + maxfilename +"::中 找不到!"
						append errorarray totostring 
					)
				)
				
			)
		)
		return  errorarray
	)
	

	
)
--op = ling_layer_controller()
--cd= op.getlayertostandard()



