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



#post.two，目前完成任务-搜集素材，场景绘制。人物素材和场景差不多搞定了，ui和动画没找到，其实找到一套其他都可以动画复用完成，但是我之前的收藏那个动画网站找不到了。于是自己试着写一个biped动画。嗯。。很糟糕
![002.png](https://upload-images.jianshu.io/upload_images/13871785-3be163d1434722f8.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)

![003.png](https://upload-images.jianshu.io/upload_images/13871785-5dc379ab4db3d8c3.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)

人物成八字。。多少和鼠标中键坏了的缘故以及3dsmax本身也不太熟悉，更重要本身不太熟悉的我还很久没碰，应该可以完成，但是估计要花太多时间去弄了。。

最后大致想了下剧情，一个乌托邦的小村庄，预计后续开发的换装系统，找不到合适的资源放弃。准备弄个选择人物的系统代替，可以选择场景内任意人物，然后在这个小村落探险接任务，可以弄个pk系统。然后左上角可以刷怪去打。等级系统也可以。嗯如果时间足够的话在上诉写的功能项进一步扩充。
