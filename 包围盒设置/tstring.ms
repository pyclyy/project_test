--- 去掉字符串的空字符 
--- 利用dotnet 
fn  tstring  strings = (
	oc = dotNetObject  "System.string" strings
	cname = oc.Trim()
	return cname 
	
)