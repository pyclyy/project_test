### 测试自动展开2uv工具     

####  测试趣向平面复杂模型情况   
+ 设置对的光滑组  
+ 模型完整没有断面     
+ 对于解包模型 一般会跟进1uv分割模型也会断开   


+ 要测试的模型   
<img  src = "im/v.png" height= "300" >    

+ 1 uv 情况  
<img  src = "im/v2.png" >   
+ 如果模型不缝合 使用工具处理2uv是这种  (碎了)    
<img  src = "im/v3.png"  height="300">   

+ 缝合模型后 2uv 默认情况    
<img  src = "im/v4.png"  ><img  src = "im/v5.png" >      

+ 再次工具处理2uv   
 <img  src = "im/v7.png"   width="300">  

+ 开启高质量     
<img  src = "im/v6.png"  width="300" >   
<img  src = "im/v8.png"  width="300" >     


#### 测试趋向圆柱的复杂模型
<img  src = "im/v9.png"  width="500" >    
<font color = #ff6666> 一般来说默认配置够用 </font>   
<img  src = "im/v10.png"  width="500" >  



#### 测试不规则多表型   
+ 模型有接缝没有缝合    
<img  src = "im/v11.png"  width="500" >  
+ 模型处理好接缝    
<img  src = "im/v12.png"  width="500" >   
+ 不规则多边形  
<img  src = "im/v13.png"  width="500" >   
<img  src = "im/v14.png"  width="500" >    

****
****
#### 还可以从通道继承    
+ 本身物体分割uv 不合理  
  <img  src = "im/v15.png"  width="500" >    

+ 利用max自己修改器分割uv    
 <img  src = "im/v16.png"  width="500" >   
 <img  src = "im/v17.png"  width="500" >  
 <img  src = "im/v18.png"  width="500" >  
+ 从从到继承然后展开 (unw)  
 <img  src = "im/v19.png"  width="500" >   

+ 和max对比 max展开没有考虑uv重叠问题，如果处理lightmap 会有问题  
<img  src = "im/v20.png"  width="500" >   

**** 
#### 支持脚本可以批处理    
<img  src = "im/v21.png"  width="500" > 