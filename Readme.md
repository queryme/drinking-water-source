#饮用水源地开发说明
##1. 运行环境
目前只能在32位的系统中运行，对于64位的系统需要装虚拟机，在虚拟机中安装32位的系统，在虚拟机中配置以下运行环境用于测试：
- window7/8/8.1
- .NET Framework 3.5（当前只能运行在3.5的环境下，4.0的运行不起来）
- ArcEngine 10.1
- YiMaGIS

##2. 开发环境
- window7/8/8.1
- visual studio 2010(编译环境:`.NET Framework 3.5`)
- ArcObjects 10.1
- YiMaGIS
- DevExpress 10.1.4.0

##3. 开发说明
我们的主要工作是在YiMaGIS的框架基础上利用AE提供的功能定制我们自己的系统，所以需要搞清楚YiMaGIS的接口以及AE的各种功能，按照YiMaGIS、AE提供的接口实现具体的业务功能。

YiMaGIS提供了两个dll文件`CommonUtility.dll`和`FrameworkCore.dll`。其中，`CommonUtility.dll`的命名空间为
```
YiMaGIS.Framework.CommonUtility
YiMaGIS.Framework.CommonUtility.General
```
`FrameworkCore.dll`的命名空间为
```
YiMaGIS.Framework.Core
YiMaGIS.Framework.Core.Configurations
YiMaGIS.Framework.Core.Editor
```
##4. 相关细节
1. [添加自定义工具](./01添加自定义工具.md)