
pyc_inscript "gt_ui_hp_exini"
struct ling_xml_data 
(
	xmldocument = undefined ,
	xmlroot = undefined ,
	-- 使用时候需要实例化
	fn init = (
		xmldocument = dotnetobject "System.Xml.XmlDocument"
		xmldocument.loadxml ("<tanpei></tanpei>")
		xmlroot = xmldocument.DocumentElement 
	),
	--- 加入节点 可以挂接很多属性
	fn Addelm  elementname attributenames  attributevalues = (
		 if attributenames.count == attributevalues.count then (
			elm = xmldocument.CreateElement(elementname)
			for i in 1 to attributenames.count  do (
				key = (attributenames[i]) as string 
				val = (attributevalues[i]) as string 
				---tm = xmldocument.CreateAttribute key val 
				elm.SetAttribute  key val 
			)
			
			xmlroot.AppendChild  elm
			 
		 )else
		 (
			 print "属性 key value 要相等"
		 )
		 
	),
	fn xmldebug  = (
		if xmlroot != undefined then (
			xmlroot.outerxml 
		)
	),
	fn savexml  filepath = (
		if xmldocument != undefined then (
			xmldocument.save (filepath)
		)			
	),
	--- 只能load 
	fn load  filepath = (
		
		if doesfileexist filepath then (
		
		xmldocument = dotnetobject "System.Xml.XmlDocument"
		xmldocument.load filepath 
		
		shader_dit = gt_ui_hp_exini()
		countxml = xmldocument.DocumentElement.ChildNodes.count
		for i in 1 to countxml do (
			getname = (xmldocument.DocumentElement.ChildNodes.item(i-1)).name
			at_key = #()
			at_val =#()
			temat = (xmldocument.DocumentElement.ChildNodes.item(i-1)).Attributes.count
			for ii in 1 to temat do (
				k = (xmldocument.DocumentElement.ChildNodes.item(i-1)).Attributes.ItemOf[ii-1].name
				v = (xmldocument.DocumentElement.ChildNodes.item(i-1)).Attributes.ItemOf[ii-1].value
				append at_key k 
				append at_val v 
					
			)
			shader_dit.item getname  #(at_key ,at_val)
		)
		shader_dit 
	    )else (
		   false 
			---print "文件不存在"
	    )
		
		
	)
	

)

-- obj = ling_xml_data ()
-- obj.init()
-- obj.addelm "node" #("黄忠","关羽","张飞") #(1.9, 2.0, 4)
-- obj.addelm "n333" #("黄忠1","关羽1","张飞1") #(1.9, 2.0, 4)
-- obj.xmldebug()
-- obj.savexml "d:\\xmltest.text"

-- - 返回字典测试ok 
-- obj= ling_xml_data()
-- c = obj.load "d:\\xmltest.text"






