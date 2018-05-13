# 设计说明
10月20号晚上，准备写这么一个程序。

>1. 腾讯云万象优图每个账户提供50G的图片存储（支持黄图检测）
>2. 可以在截图之后，直接点击上传，自动将截图的程序上传到万象优图，不再有复杂的上传操作 
>3.也可以主动上传图片

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407807.jpg "在这里输入图片标题")


# 设计实现

如上图所说，本来想对截图直接生成`base64`编码的字符串，然后使用该字符串利用二进制上传到腾讯云万象优图。但是，现在已有的`.net API`不支持二进制文件的上传，因此，这里就对不起观众了。现在采用的方案是：将截图程序生成的截图（不需要保存）由程序在保存在程序的根目录下的`uplaod`文件夹下，然后再利用本地文件路径进行上传。

# 程序下载
我已经将打包好的程序，放在了github的仓库上，下载地址为

[点我下载](https://github.com/sixtrees/MagicImage/releases)

# 程序安装

安装过程比较简单，直接一步一步的上图片

第一步是选择安装路径，不要安装到`C盘`的其他目录，因为程序可能获取不到创建文件夹和文件的选项。程序默认的是`C:\ProgramData\MagicImage`路径，这个路径的开放程度比较高。    

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407808.jpg "在这里输入图片标题")


第二步是提示你要创建桌面快捷方式，最好是选择创建一下快捷方式，不然，不方便你使用啦

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407809.jpg "在这里输入图片标题")

第三步是确认你的创建快捷方式的选项

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193448222.jpg "在这里输入图片标题")

第四步选择`install`，很快就创建完成了

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193448234.jpg "在这里输入图片标题")

# 程序使用

程序刚打开的界面如下

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407812.jpg "在这里输入图片标题")

设置自己的万象优图的APPID,SECRET_ID,SECRET_KEY，BUCKET_NAME的信息，这里我默认的配置是我自己的。

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193448235.jpg "在这里输入图片标题")

**关于如何配置自己的万象优图信息，参考下一节内容**

# 使用场景

## 拖拽的方式，上传图片

这种方式，就是把图片往程序的界面上，拖动

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407850.jpg "在这里输入图片标题")

拖拽后，程序会自动加载该图片

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407825.jpg "在这里输入图片标题")

点击程序界面下面的`上传拖拽图像`，就可以完成上传，并且自动在系统粘贴板上设置`markdown`格式的`img`标签


![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407827.jpg "在这里输入图片标题")

下面，我将使用`CTRL+V`，粘贴程序生成的`img`标签

![请说明图片](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407832.jpg)


## 截图的方式，上传图片

首先，使用`QQ截图功能`或者其他截图软件，进行截图，示例就是截的编辑本文档的界面的图片，截图之后，不需要你手动保存的。下面是我截的图片

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193448284.jpg "在这里输入图片标题")

完成截图之后，回到程序界面，点击程序下面的`上传截图`按钮，

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407851.jpg "在这里输入图片标题")

就可以完成上传，并且自动在系统粘贴板上设置`markdown`格式的`img`标签，下面，我将使用`CTRL+V`，粘贴程序生成的`img`标签

![请说明图片](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407853.jpg)

**程序的使用就介绍到这里**

# 获取自己的万象优图的信息

首先登陆自己的万象优图`https://www.qcloud.com/product/ci.html`

选择立即使用，进行订购页面

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407880.jpg "在这里输入图片标题")

选择图片空间

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407861.jpg "在这里输入图片标题")

添加图片空间

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407836.jpg "在这里输入图片标题")

等待系统进行处理

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407870.jpg "在这里输入图片标题")

创建成功之后，查看自己的`APPT_ID`和`BUCKET_NAME`,如下图箭头和文字注释

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193407838.jpg "在这里输入图片标题")

已经有了`APPT_ID`和`BUCKET_NAME`，我们还需要`SECRET_ID`和`SECRET_KEY`，下图就是获取这两项的示例

![输入图片说明](https://jianshu-1251626064.cosgz.myqcloud.com/md-document/1526193448300.jpg "在这里输入图片标题")

有了这四个东西，就可以在程序的`设置`菜单中，将图片的仓库配置成你自己的了的，就可以尽情享受你的50G存储空间了。
