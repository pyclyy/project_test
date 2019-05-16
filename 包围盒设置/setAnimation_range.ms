

fn setAnimation_range  = 
(
	allkey = #()
	ioo= 0 
	for i in objects  do (
		if classof i == Biped_Object then (
			ioo+=1 
			indexbip = 500 
			--if ioo <3 then (  这里应该是4 3 只是会播放 12节点按照bip 排序 Bip002  :Bip002 Footsteps
			-- 通常是他们俩 下面控制器不对，所以以来来说这里是 4  20180921 修改 
			if ioo <4 then (
				onoff = true 
			
				while  onoff do (
					try (
						
							coc  =  i.transform.controller 
							if coc as string == "Controller:Body" then (
								--------第一次报错 处理质心 
								---- 20190509 独立质心帧计算方法 
								bip =  coc 
								vertCont = bip.vertical.controller
								horzCont = bip.horizontal.controller
								turnCont = bip.turning.controller
								
								 (vk = biped.getKey vertCont indexbip ; vk = vk.time) 
								 (hk = biped.getKey horzCont indexbip ;hk = hk.time)  
								 (tk = biped.getKey turnCont indexbip ; tk =tk.time ) 
								
								indexbip = amax  #(vk ,hk ,tk )
								
							)else (
							
							c = biped.getKey   coc  indexbip 
							indexbip = c.time 

							)
							onoff =false 
							append allkey indexbip

						
					)catch (

						indexbip -=1 
						onoff = true 
						if indexbip == 0 then onoff = false 
						)	
				)
			)
			
			
		)else (
		bi1 = try (numKeys i[3][1].controller) catch (0)
		bi2 = try (numKeys i[3][2].controller) catch (0)
		bi3 = try (numKeys i[3][3].controller) catch (0)
		
			
		ci1 = try (getKeyTime  i[3][1].controller  bi1 )catch (0f)
		ci2 = try (getKeyTime  i[3][2].controller  bi2 )catch (0f)
		ci3 = try (getKeyTime  i[3][3].controller  bi3 )catch (0f)
		ci  =amax #(ci1  ,ci2  ,ci3 )
			append allkey  ci 
		)
		
	)
	cmax = amax (allkey)
	cmin = amin (allkey)
	if cmin == cmax then  cmax = cmin+1 
	animationRange = interval cmin  cmax 
)
--setAnimation_range()