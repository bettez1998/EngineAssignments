# 第六周作业 对场景进行光照、阴影、渲染、后处理等优化
注：可执行文件超过无法上传git，已上传至百度网盘，辛苦老师下载批阅，谢谢！
（链接：https://pan.baidu.com/s/1uwrzPA4V_1gW9717dbBHUA 
提取码：gsch）
附工程文件导出的package,若工程文件打不开可在新项目里导入查看

场景为森林，想要做出午后阳光下森林场景的感觉，进行以下尝试
1.Rendering的color space选择Linear
2.调节太阳光颜色和强度，选择soft shadows并调参数使其适合场景（尝试添加cookie贴图，感觉不太合适所以没用），对shadow distance进行调节以符合树叶阴影的感觉
3.给摄像机添加post processing后处理，开启FXAA抗锯齿，并尝试各效果最终保留color grading, bloom, ambient occlusion和auto exposure
