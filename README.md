# FastFramework
🚀FastFramework是一款基于.NET 8的灵活快速开发框架，集成通用RBAC权限管理、统一认证授权、JWT、数据仓储、配置中心、日志系统、ELK等相关功能。


# 后端技术栈
## ASP.NET Core
* [为什么选择ASP.NET Core？](https://docs.microsoft.com/zh-cn/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0#why-choose-aspnet-core)
* [aspnetcore源码](https://github.com/dotnet/aspnetcore)
* [各大编程语言性能测试结果的可视化图表](https://www.oschina.net/news/201120/programming-language-benchmarks)

> 首先请你不要再停留在ASP.NET 4.x时代了，不要一听到.NET就是性能不行、不能跨平台、拖控件等等各种诟病。首先ASP.NET Core是对 ASP.NET 4.x 的重新设计（包括体系结构上的更改），是一个跨平台的高性能、精简、模块化、更支持云原生的开源框架。

## Entity Framework Core
* [EF Core源码](https://github.com/dotnet/efcore)

> Entity Framework (EF) Core 是轻量化、可扩展、开源和跨平台版的常用 Entity Framework 数据访问技术。
**EF Core 可用作对象关系映射程序 (O/RM)，这可以实现以下两点：**
* 使 .NET 开发人员能够使用 .NET 对象处理数据库。
* 无需再像通常那样编写大部分数据访问代码。


## Dapper
* [Dapper源码](https://github.com/DapperLib/Dapper)

> Dapper是一个简单的.NET对象映射器，在速度方面具有"King of Micro ORM"的头衔，几乎与使用原始的ADO.NET数据读取器一样快。ORM是一个对象关系映射器，它负责数据库和编程语言之间的映射。Dapper通过扩展IDbConnection提供一些有用的扩展方法去查询您的数据库。


## MiniProfiler
* MinniProfiler源码
* [MiniProfiler for .NET文档](https://miniprofiler.com/dotnet/)

> MiniProfiler是一款针对.NET, Ruby, Go and Node.js的性能分析的轻量级程序。使用MiniProfiler可以用于分析你的应用程序的库和UI执行的时间花在哪里、运行了哪些查询以及您想要添加的任何其他自定义时间，MiniProfiler可以帮助您调试问题并优化性能。


## AutoMapper
* [AutoMapper源码 ](https://github.com/AutoMapper)

> AutoMapper是一个OOM（Object-Object-Mapping）对象关系映射组件，从它的英文名字中可以看出，AutoMapper主要是为了实现实体间的相互转换，从而避免我们每次采用手工的方式进行转换。


## AutoFac
* [AutoFac源码](https://github.com/autofac/Autofac)

> Autofac 是.NET框架中最常用的依赖注入框架之一。相比.Net Core标准的依赖注入库, 它提供了更多高级特性, 比如动态代理和属性注入等。


## Quartz.NET
* [Quartz.NET源码](https://github.com/quartznet/quartznet)

> Quartz.NET是一个开源、强大、轻量的作业调度框架。


## Serilog
* [Serilog源码](https://github.com/serilog/serilog)

> Serilog是一个开源，简单易用.NET应用程序的诊断日志库，并且可以在所有最新的 .NET 平台上运行。支持结构化日志记录，对复杂、分布式、异步应用程序的支持非常出色。


## FreeRedis
* [FreeRedis源码](https://github.com/2881099/FreeRedis)

> FreeRedis是基于.NET的Redis客户端（继CSRedisCore之后重写），支持 .NET Core 2.1+、.NET Framework 4.0+ 以及 Xamarin。

## AspNetCoreRateLimit
* [AspNetCoreRateLimit源码](https://github.com/stefanprodan/AspNetCoreRateLimit)

> AspNetCoreRateLimit是一个ASP.NET Core速率限制的解决方案，旨在控制客户端根据IP地址或客户端ID向Web API或MVC应用发出的请求的速率。AspNetCoreRateLimit包含一个IpRateLimitMiddleware和ClientRateLimitMiddleware，每个中间件可以根据不同的场景配置限制允许IP或客户端，自定义这些限制策略，也可以将限制策略应用在每个API URL或具体的HTTP Method上。


# 前端技术栈
## uni-app
* [uni-app官网地址](https://uniapp.dcloud.io/)
* [uni-app跨平台框架介绍和快速入门（为什么选择uni-app开发？）](https://www.cnblogs.com/Can-daydayup/p/12008874.html)

> uni-app是一个使用 Vue.js (opens new window)开发所有前端应用的框架，开发者编写一套代码，可发布到iOS、Android、Web（响应式）、以及各种小程序（微信/支付宝/百度/头条/飞书/QQ/快手/钉钉/淘宝）、快应用等多个平台。

## Vben Admin
* [Vben Admin](https://github.com/vbenjs/vue-vben-admin)
> Vue-Vben-Admin 是一个基于 Vue3.0、Vite、 Ant-Design-Vue、TypeScript 的后台解决方案，目标是为开发中大型项目提供开箱即用的解决方案。包括二次封装组件、utils、hooks、动态菜单、权限校验、按钮级别权限控制等功能。项目会使用前端较新的技术栈，可以作为项目的启动模版，以帮助你快速搭建企业级中后台产品原型。


# 认证授权
## JWT(Json Web Token)
> JWT 是目前最流行的跨域认证解决方案，是一种基于 Token 的认证授权机制。 从 JWT 的全称可以看出，JWT 本身也是 Token，一种规范化之后的 JSON 结构的 Token。

# 数据库(SQL/NoSQL)
* [MySql](https://www.mysqlzh.com/)
* [Redis](http://www.redis.cn/)
* [Mongodb](https://docs.mongoing.com/)


# 开发工具
* [Visual Studio 2022](https://visualstudio.microsoft.com/zh-hans/vs/)
* [Visual Studio Code](https://code.visualstudio.com/)
* [AnotherRedisDesktopManager](https://github.com/qishibo/AnotherRedisDesktopManager)
* [微信小程序开发工具](http://www.ionic.wang/weixin/devtools/download.html)
* [HBuilderX](https://dcloud.io/hbuilderx.html)
* [Navicate](https://navicat.com.cn/)
* [Portainer](https://www.portainer.io/)


# 日志分析系统
* [Elasticsearch](https://www.elastic.co/cn/elasticsearch/https://www.elastic.co/cn/elasticsearch/)
* [Logstash](https://www.elastic.co/cn/logstash/)
* [kibana](https://www.elastic.co/cn/kibana/)


# 云原生部署容器
* [Docker](https://www.docker.com/)

# 服务器操作系统
* Ubuntu 20.04 LTS
> Ubuntu是最热门的Linux发行版之一，是一款开放源代码的免费软件，基于Debian Linux操作系统，其易用性和稳定性均非常出色，并且拥有非常强大成熟的社区资源。

# 其他工具
## 接口管理工具
* [Swagger](https://swagger.io/)

## 在线文档工具
* [语雀](https://www.yuque.com/login?platform=wechat&inviteToken=357df65e3061673e3b03a080fade2e490b6e27957dc60178cd6d3e0d50b576e2)

## 流程图思维导图工具
* [ProcessOn](https://www.processon.com/i/5c0db7cbe4b0c87510c69fdc)




