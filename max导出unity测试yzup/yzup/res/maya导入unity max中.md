#  测试由于maya 导入max utnity中  
****
测试环境 ：
+ max2018 
+ maya2018 
+ unity5.6 
  

<font color = #ff0000 >【以下说的x轴 y轴 z轴都是相对于maya 中方向来说】 </font>
## maya中 【建立初始状态】
1. 壶口同x正方向，小壶口在z负方向
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/maya%E4%B8%AD%E5%88%9D%E5%A7%8B%E7%8A%B6%E6%80%81.jpg?raw=true)

1. 分别zup yup 导出  __max__ __unity__ 使用fbx2014 2015 导出

## unity中  

【yup导出】

   1.  x轴正好反项
   2.  z轴不反，状态反了
   3.  x 轴没有旋转
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/maya%E5%AF%BC%E5%85%A5unity-yup.jpg?raw=true)
   
【zup导出】

   1.  x轴正好反项
   2.  z轴不反，状态反了
   3.  x 轴没有旋转
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/maya%E5%AF%BC%E5%85%A5unity-zup.jpg?raw=true)


## max中

【yup导出】
   1.  x轴不变
   2.  z轴反，状态对
   3.  x 轴有旋转90度
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/maya%E5%AF%BC%E5%85%A5max%E4%B8%ADyup.jpg?raw=true)

【zup导出】
   1.  x轴不变
   2.  z轴反，状态变
   3.  x 轴没有旋转
![](https://github.com/pyclyy/project_test/blob/master/max%E5%AF%BC%E5%87%BAunity%E6%B5%8B%E8%AF%95yzup/yzup/res/im/maya%E5%AF%BC%E5%85%A5maxzup.jpg?raw=true)


## 结论
### <font color = #ff99333> 结论1 ：maya中标准资源(位移旋转000 缩放111) yup zup ，导入 unity ，x轴正好相反 x轴没有旋转 </font> 
### <font color = #ff99333> 结论2 ：maya中标准资源(位移旋转000 缩放111)，yup 导入 max 中 状态不变 x轴旋转90度 </font> 
### <font color = #ff99333> 结论3： maya中标准资源(位移旋转000 缩放111)，zup 导入 max中 资源倾倒 x轴没有旋转 </font> 