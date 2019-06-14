#  测试由于max 导入maya utnity中  
****
测试环境 ：
+ max2018 
+ maya2018 
+ unity5.6 
  

<font color = #ff0000 >【以下说的x轴 y轴 z轴都是相对于max 中方向来说】 </font>
## max中 【建立初始状态】
1. 壶口同x正方向，小壶口在y正方向
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/%E9%BB%98%E8%AE%A4.jpg?raw=true)

2. 分别zup yup 导出  __maya__ __unity__ 使用fbx2014 2015 导出

## unity中  

【yup导出】

   1.  x轴正好反项
   2.  y轴反向
   3.  x 轴有旋转 -90 度 
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/max%E5%AF%BC%E5%87%BAunity%E4%B8%AD.jpg?raw=true)
   
【zup导出】

   1.  x轴正好反项
   2.  y轴反向
   3.  x 轴有旋转 -90 度 
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/max%E5%AF%BC%E5%87%BAunityzup.jpg?raw=true)

## maya中

【yup】 

1. x轴正确
2. y轴正好是反的
3. x轴有一个-90度旋转
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/unity%E5%AF%BC%E5%85%A5maya%20yup.jpg?raw=true)

【zup】
1. x轴正确
2. y轴正好是反的
3. x轴有一个-90度旋转
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/unity%E5%AF%BC%E5%85%A5mayazup.jpg?raw=true)


## 结论
### <font color = #ff99333> 结论1 ：max中标准资源(位移旋转000 缩放111)，导入 unity  导入maya中，x轴都有旋转 -90度 </font> 
### <font color = #ff99333> 结论2 ：max中标准资源(位移旋转000 缩放111)，导入 unity 中 x 轴180 度镜像 y轴180镜像 </font> 
### <font color = #ff99333> 结论3： max中标准资源(位移旋转000 缩放111)，导入 maya中 型没有变，坐标系旋转90度，x = -90</font> 
