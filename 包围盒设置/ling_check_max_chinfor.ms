

---**************************** ************************************************---
---**************************** ************************************************---
---**************************** ************************************************---
------- 配置文件key 可以互换  但是定义的value 不可以互换 都有索引引用--------------

---**************************** ************************************************---
---**************************** ************************************************---
---**************************** ************************************************---
---开始第一个文件检查
--- 实现max文件记录
--- 上面的三个每个函数必须加载  分别是：
   -----1 最后输出的颜色   
   -----2 最后输出的结构体  
   -----3 最后输出 infor   
   -----4 关于 name 要进行酌情输出，看是不是有必要
   -----5 新加入obj 最为函数的返回    
---关于每个检查函数都有3个传入 
--- 挡圈max文件
--- 标准max 文件
--- 标准选择集合
--- infor 文件 格式 “正确@警告@错误” 写法

--- 每个函数要求最后返回标准结构数据

struct  ling_check_max_chinfor  (
	
	artheroelod = #(15000 , 7000 ,3000),
	heroelod   = #(3600 , 1400 ,  700  ),
	ogrelod    = #(3600 , 1400 ,  700  ),
	soldierlod    = #(800 ,500 , 250 ),
	
	artheroepath = "character\\art_hero",
	heroepath    = "character\\hero",
	ogrepath    = "character\\monster",
	soldierpath = "character\\soldier",
	artheroebone = 100 ,
	heroebone =50 ,
	ogrebone=100,
	soldierbone =20,
	heroskincount =3 ,
	artheroskincount =4 ,
	soldierskincount =2 ,
	posrotationscale = #([0,0,0], (quat 0 0 0 1) ,[1,1,1]),
	face0 = 0.01,
	sprere = "Sphere001",
	sprerekey = #(7 ,10),
	infor = "info",
	checkfile = "art\\character",
	Amappath ="asset\character",
	Aformatmap =#(".tga",".dds"),
	mapsize  = #(32,64,128,256,512,1024),
	data ="data",
	anim="data",
	indata = #("*.ZTL","*.zip"),
	lods   = #("_lod00" , "_lod01", "_lod02"),
	building = #("art\\building","art\\res"),
	building_x = #("asset\\building","asset\\res"),
	ling ="ling",
	h_ling= "h_ling",
	loddis = #(#(3,20,50,100),#(5,30,80,100),#(10,20,80,300),#(100,20,80,300),#(1000,20,80,1000)), --- 第一个角色高度米  后面3个是lod切换距离 
	--- 第一个是判断角色类型 第二个是给的ling 引擎的shader类型
	character_mat =#(#("character\\art_hero","Default" ),#("character\\soldier","DefaultFactionColor"), #("character\\monster","Default" )),
	--- data 内的文件夹类型
	data_ch = #("spp" ,"ztl","psd" , "tmp"),
	distances = "_distance",
	bb= "boundingbox", --- bb 文件写入  包围盒 
	bakelods   = #("lod00" , "lod01", "lod02"),
	textag=#("@d","@n","@l","@ld0","@ld1","@ld2","@ld3")
	
	
	
	
	
)