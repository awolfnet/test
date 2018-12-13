这是一个包含错误的项目

错误的描述是这样的：

捕获1.JPG:
class test.App_Code.HTTP
"C:\code\test\test\App_Code\HTTP.cs"中的类型"HTTP"与"test,Version=1.0.0.0,Culture=neutral,PublicKeyToken=null"中的导入类型"HTTP"冲突。请使用"C:\code\test\test\App_Code\HTTP.cs"中定义的类型。

捕获2.JPG:
无法将类型"test.App_Code.HTTP.METHOD[App_Web_taut0g5v,Version=0.0.0.0,Cultrue=neutral,PublicKeyToken=null]"隐式转换为"test.App_Code.HTTP.METHOD[App_Web,Version=0.0.0.0,Cultrue=neutral,PublicKeyToken=null]"。存在一个显示转换（是否缺少强制转换？）

简单介绍一下我的想法
一个HTTP类，里面有个枚举类型，叫METHOD，然后另外一个模型类，叫PackageModel，其中一个属性就是HTTP.METHOD，然后在Prerouting类中有一个方法，RoutePackage，其中一个参数就是HTTP.METHOD，然后在方法内部使用这个参数时，就会出现这个错误！

我很好奇为什么会这样，大家说是引用了自身，但是我无论在项目属性的引用，还是解决方案资源管理器的引用，都没有找到引用自身的条目。
