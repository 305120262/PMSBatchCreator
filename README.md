# PMSBatchCreator 
##ArcGIS符号图集生成工具
使用ArcGIS符号图集生成工具，可以根据指定的ArcGIS style符号库文件，批量输出成PDF格式的符号图集，以供打印参考。输出内容支持点、线、面符号。输出的PDF图集支持多页面。
参数：
+ 符号库：指定的ArcGIS style符号库文件。
+ 类别：要输出的ArcGIS符号分类的类别名。
+ 图标大小：输出的图标的大小，单位为点。
+ 绘制网格：输出图标将会以网格方式排列输出，指定是否绘制网格线。
+ 点符号：指定是否输出点符号。
+ 线符号：指定是否输出线符号。
+ 面符号：指定是否输出面符号。
+ 输出PDF：指定输出的PDF图集保存路径。


##图片符号批量生成工具
对于比较复杂的彩色点符号，可以使用ArcGIS提供的图片符号。该工具能根据包含图标集合的文件夹批量生成ArcGIS的点符号，并保存在指定的符号库中。
参数：
+ 图标文件夹：包含图标集合的文件夹，可以嵌套子文件夹。
+ 图片格式：指定图标的图片格式，可选PNG、BMP、JPEG、EMF。图标默认是白色为透明背景色。
+ 符号大小：生成的ArcGIS点符号大小，单位为点。
+ 类别：生成的ArcGIS点符号分类的类别名。
+ 输出符号库：指定的输出符号库保存路径，假如是已经存在的符号库，则自动添加新增符号。

##批量生成ArcGIS点符号到图标
对于已有的ArcGIS点符号，例如使用字体符号制作的包含多个符号图层的点符号，绘制效率不高。该工具能根据指定的符号集批量生成ArcGIS的图片点符号，并保存在指定的符号库中，使用图片点符号能大大提高绘制效率。

参数：
+ 符号库：指定的ArcGIS style符号库文件。
+ 类别：要输出的ArcGIS符号分类的类别名。
+ 图片输出目录：指定的存放图标的文件夹。
+ 输出符号库：指定的输出符号库保存路径，假如是已经存在的符号库，则自动添加新增符号。
+ 图片位数：8位或者32位的PNG图标位深，都支持透明。


