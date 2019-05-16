
fn ling_openmax  maxpath = (
	filetype =getfilenametype maxpath 
	if tolower(filetype) == ".max" then (
		resetMaxFile   #noPrompt 
		if (maxversion())[1]> 18000 then (
			--- 发现问题在高版本中，这里问题比较多， 多了很多
			loadmaxfile maxpath  useFileUnits:true  quiet:true 
			
		)else (
		loadmaxfile maxpath  useFileUnits:true  quiet:true
		)
	)
)