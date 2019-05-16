
struct gt_ui_hp_exini (
	totokey =#(#(),#()),
	fn help = (
		gt_10000_help = " 该类只要是对ini 文件配置进行自定话操作 
					同时也可以 方便吧数据放过该类进行管理 
					数据是使用模拟字典进行管理的 
					***************** 字典的key  value 提前都需要序列化**************************
				
			method::         getvalue key  
						  通过key 来获取value  
						  如果key 不存在 返回 undefined 
			method::	getkey_value  value
						******这个效果要注意 使用非常危险
						因为value 很多时候可能相同 
						通过value 来获取key 
						
						慎用*****
						
			method::	  add key  value 
						  给现有字典加入key value  
						 如果加入成功 返回true 
						 不成功返回false
						一本不成功多半是出现了相同的key 
			method::	 clear ()
						对字典进行初始化操作 
			method::	getkey  key 
				  		bool	判断key是否存在
			method::	getkeys ()
						获取全部的key  数组
			method::	getvalues ()
						获取全部的values 
			method::	 del index 
						删除字典中某一项
						可以删除返回true 
						不可以删除返回false 
			method::    dlekey  key 
						删除自定的 key 对应的value 
						可以删除返回true 
						不可以删除返回false 
			method::	item  key value
						 可以实现add的所有功能
						 如果出现相同的key 则对value 进行更改操作
						更改成功 返回true
						总是返回true
			
				
			
	
		"
	
	
	),
	totoinifile = "",
	totosion ="",
	fn getvalue  key = (
		coc =undefined 
		if totokey.count >0 then (
			 co = findItem  totokey[1]  key
			if co !=0 then (
				coc = totokey[2][co]
			)
		)	
		return coc 
	),
	fn  getkey_value  value = (
		coc =undefined 
		if totokey.count >0 then (
			 co = findItem  totokey[2]  value
			if co !=0 then (
				coc = totokey[1][co]
			)
		)	
		return coc 	
	),
	fn add  key  value = (
		---同样的key只能加入一次 
		co = findItem  totokey[1]  key 
		if co==0 then (
		append  totokey[1]  key 
		append totokey[2]  value 	
		 true 
		)else false 
		 
		
	),
	fn item  key value = (
		co = findItem  totokey[1]  key 	
		if co !=0 then (
			totokey[2][co]= value 
			true 
		)else (
			append  totokey[1]  key 
			append totokey[2]  value 	
			true 
		)
		 
	),
	fn clear =(
		totokey =#(#(),#())	
	),
	fn getkey  key = (
		co = findItem  totokey[1]  key 
		if co ==0 then return  false  else return true 
			
	),
	fn getkeys = (
		return  totokey[1]	
	),
	fn getvalues = (
		return totokey[2]	
	),
	fn del index = (
		if  totokey[1].count > index then (
			 one = deleteItem  totokey[1]  index 
			two = deleteItem totokey[2] index 
			totokey = #(one ,two )
			true 
		)else false 
	),
	fn delkey    key = (
		co =  findItem  totokey[1]  key 
		if co ==0 then (
			false 
		)else (
			one = deleteItem  totokey[1]  co 
			 two = deleteItem totokey[2] co  
			totokey = #(one ,two )
			true 
		)
	)
	
)