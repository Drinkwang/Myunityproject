# 这是我的一个mmo rpg的项目，是基于普通的mvc，并没有基于spring，晚上写完这部分内容，大脑有点发昏，所以就写错了
this is rpg for all The whole platform（eg：andriod，widnow。nothing to else）
该项目基于mvc搭建，通过view controller model的一个物品栏，之后会添加更多功能，包括场景搭建在内的，例如任务框，使用物品，状态栏。接受任务，完成任务。线程池储存敌方单位，以及一个会追踪并攻击玩家的ai
最终项目将在安卓上运行。

# 计划日程表

```完整的物品栏+任务栏|
'''MVC框架实现（目前已经完成了）
```搜集素材，人物基础移动+场景绘制
---接受任务 实现任务的业务逻辑
---people基类，人物ui，状态栏，以及敌人继承基类
---线程池生成怪物
---怪物ai
---具体任务细节
---详细打磨
---手机上运行

# 目前实现效果
通过mvc使物品栏model层数据发生变化，从而回传再调用view调用组成的生成gameobject实例

```



![beget.png](https://upload-images.jianshu.io/upload_images/13871785-dad9e5e1060ec40d.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
