
using Bode.Services.Core.Models.Delivery;
using OSharp.Data.Entity.Default;
using OSharp.Data.Entity.Migrations;
using System.Collections.Generic;


namespace Bode.Services.Implement.DbSeed
{
    public class CreateCitySeedAction : ISeedAction<DefaultDbContext>
    {
        /// <summary>
     /// 定义种子数据初始化过程
     /// </summary>
     /// <param name="context">数据上下文</param>
        public void Action(System.Data.Entity.DbContext context)
        {
            context.Set<Province>()
                .AddRange(new List<Province>()
                {
                    new Province() { Name="北京市",Citys=new List<City>(){new City() { Name="北京市"}} },
                    new Province() { Name="上海市",Citys=new List<City>(){new City() { Name="上海市"}} },
                    new Province() { Name="重庆市",Citys=new List<City>(){new City() { Name="重庆市"}} },
                    new Province() { Name="天津市",Citys=new List<City>(){new City() { Name="天津市"}} },
                    new Province() { Name="山东省",Citys=new List<City>()
                    {
                        new City() { Name="济南市"},
                        new City() { Name="青岛市"},
                        new City() { Name="临沂市"},
                        new City() { Name="济宁市"},
                        new City() { Name="菏泽市"},
                        new City() { Name="烟台市"},
                        new City() { Name="淄博市"},
                        new City() { Name="泰安市"},
                        new City() { Name="潍坊市"},
                        new City() { Name="日照市"},
                        new City() { Name="威海市"},
                        new City() { Name="滨州市"},
                        new City() { Name="东营市"},
                        new City() { Name="聊城市"},
                        new City() { Name="德州市"},
                        new City() { Name="莱芜市"},
                        new City() { Name="枣庄市"}
                    } },
                    new Province() { Name="山西省",Citys=new List<City>()
                    {
                        new City() { Name="太原市"},
                        new City() { Name="大同市"},
                        new City() { Name="运城市"},
                        new City() { Name="长治市"},
                        new City() { Name="晋城市"},
                        new City() { Name="忻州市"},
                        new City() { Name="临汾市"},
                        new City() { Name="吕梁市"},
                        new City() { Name="晋中市"},
                        new City() { Name="阳泉市"},
                        new City() { Name="朔州市"}
                    } },
                    new Province() { Name="江苏省",Citys=new List<City>()
                    {
                        new City() { Name="苏州市"},
                        new City() { Name="徐州市"},
                        new City() { Name="盐城市"},
                        new City() { Name="无锡市"},
                        new City() { Name="南京市"},
                        new City() { Name="南通市"},
                        new City() { Name="连云港市"},
                        new City() { Name="常州市"},
                        new City() { Name="镇江市"},
                        new City() { Name="扬州市"},
                        new City() { Name="淮安市"},
                        new City() { Name="泰州市"},
                        new City() { Name="宿迁市"}
                    } },
                    new Province() { Name="河南省",Citys=new List<City>()
                    {
                        new City() { Name="郑州市"},
                        new City() { Name="南阳市"},
                        new City() { Name="新乡市"},
                        new City() { Name="安阳市"},
                        new City() { Name="洛阳市"},
                        new City() { Name="信阳市"},
                        new City() { Name="平顶山市"},
                        new City() { Name="周口市"},
                        new City() { Name="商丘市"},
                        new City() { Name="开封市"},
                        new City() { Name="焦作市"},
                        new City() { Name="驻马店市"},
                        new City() { Name="濮阳市"},
                        new City() { Name="三门峡市"},
                        new City() { Name="漯河市"},
                        new City() { Name="许昌市"},
                        new City() { Name="鹤壁市"},
                        new City() { Name="济源市"}
                    } },
                    new Province() { Name="河北省",Citys=new List<City>()
                    {
                        new City() { Name="石家庄市"},
                        new City() { Name="唐山市"},
                        new City() { Name="保定市"},
                        new City() { Name="邯郸市"},
                        new City() { Name="邢台市"},
                        new City() { Name="河北区"},
                        new City() { Name="沧州市"},
                        new City() { Name="秦皇岛市"},
                        new City() { Name="张家口市"},
                        new City() { Name="衡水市"},
                        new City() { Name="廊坊市"},
                        new City() { Name="承德市"}
                    } },
                    new Province() { Name="浙江省",Citys=new List<City>()
                    {
                        new City() { Name="温州市"},
                        new City() { Name="宁波市"},
                        new City() { Name="杭州市"},
                        new City() { Name="台州市"},
                        new City() { Name="嘉兴市"},
                        new City() { Name="金华市"},
                        new City() { Name="湖州市"},
                        new City() { Name="绍兴市"},
                        new City() { Name="舟山市"},
                        new City() { Name="丽水市"},
                        new City() { Name="衢州市"}
                    } },
                    new Province() { Name="陕西省",Citys=new List<City>()
                    {
                        new City() { Name="西安市"},
                        new City() { Name="咸阳市"},
                        new City() { Name="宝鸡市"},
                        new City() { Name="汉中市"},
                        new City() { Name="渭南市"},
                        new City() { Name="安康市"},
                        new City() { Name="榆林市"},
                        new City() { Name="商洛市"},
                        new City() { Name="延安市"},
                        new City() { Name="铜川市"}
                    } },
                    new Province() { Name="湖南省",Citys=new List<City>()
                    {
                        new City() { Name="长沙市"},
                        new City() { Name="邵阳市"},
                        new City() { Name="常德市"},
                        new City() { Name="衡阳市"},
                        new City() { Name="株洲市"},
                        new City() { Name="湘潭市"},
                        new City() { Name="永州市"},
                        new City() { Name="岳阳市"},
                        new City() { Name="怀化市"},
                        new City() { Name="郴州市"},
                        new City() { Name="娄底市"},
                        new City() { Name="益阳市"},
                        new City() { Name="张家界市"},
                        new City() { Name="湘西市"}
                    } },
                    new Province() { Name="湖北省",Citys=new List<City>()
                    {
                        new City() { Name="武汉市"},
                        new City() { Name="宜昌市"},
                        new City() { Name="襄樊市"},
                        new City() { Name="荆州市"},
                        new City() { Name="恩施市"},
                        new City() { Name="黄冈市"},
                        new City() { Name="孝感市"},
                        new City() { Name="十堰市"},
                        new City() { Name="咸宁市"},
                        new City() { Name="黄石市"},
                        new City() { Name="仙桃市"},
                        new City() { Name="天门市"},
                        new City() { Name="随州市"},
                        new City() { Name="荆门市"},
                        new City() { Name="潜江市"},
                        new City() { Name="鄂州市"},
                        new City() { Name="神农架林区"}
                    } },
                    new Province() { Name="广东省",Citys=new List<City>()
                    {
                        new City() { Name="东莞市"},
                        new City() { Name="广州市"},
                        new City() { Name="中山市"},
                        new City() { Name="深圳市"},
                        new City() { Name="惠州市"},
                        new City() { Name="江门市"},
                        new City() { Name="珠海市"},
                        new City() { Name="汕头市"},
                        new City() { Name="佛山市"},
                        new City() { Name="湛江市"},
                        new City() { Name="河源市"},
                        new City() { Name="肇庆市"},
                        new City() { Name="清远市"},
                        new City() { Name="潮州市"},
                        new City() { Name="韶关市"},
                        new City() { Name="揭阳市"},
                        new City() { Name="阳江市"},
                        new City() { Name="梅州市"},
                        new City() { Name="云浮市"},
                        new City() { Name="茂名市"},
                        new City() { Name="汕尾市"}
                    } },
                    new Province() { Name="福建省",Citys=new List<City>()
                    {
                        new City() { Name="漳州市"},
                        new City() { Name="厦门市"},
                        new City() { Name="泉州市"},
                        new City() { Name="福州市"},
                        new City() { Name="莆田市"},
                        new City() { Name="宁德市"},
                        new City() { Name="三明市"},
                        new City() { Name="南平市"},
                        new City() { Name="龙岩市"}
                    } },
                    new Province() { Name="云南省",Citys=new List<City>()
                    {
                        new City() { Name="昆明市"},
                        new City() { Name="红河州"},
                        new City() { Name="大理州"},
                        new City() { Name="文山州"},
                        new City() { Name="德宏州"},
                        new City() { Name="曲靖市"},
                        new City() { Name="昭通市"},
                        new City() { Name="楚雄市"},
                        new City() { Name="保山市"},
                        new City() { Name="玉溪市"},
                        new City() { Name="丽江地区"},
                        new City() { Name="临沧地区"},
                        new City() { Name="思茅地区"},
                        new City() { Name="西双版纳州"},
                        new City() { Name="怒江州"},
                        new City() { Name="迪庆州"}
                    } },
                    new Province() { Name="贵州省",Citys=new List<City>()
                    {
                        new City() { Name="贵阳市"},
                        new City() { Name="遵义市"},
                        new City() { Name="黔南州"},
                        new City() { Name="黔东南州"},
                        new City() { Name="黔西南州"},
                        new City() { Name="毕节地区"},
                        new City() { Name="铜仁地区"},
                        new City() { Name="安顺市"},
                        new City() { Name="六盘水市"}
                    } },
                    new Province() { Name="四川省",Citys=new List<City>()
                    {
                        new City() { Name="成都市"},
                        new City() { Name="绵阳市"},
                        new City() { Name="广元市"},
                        new City() { Name="达州市"},
                        new City() { Name="南充市"},
                        new City() { Name="德阳市"},
                        new City() { Name="广安市"},
                        new City() { Name="阿坝州"},
                        new City() { Name="巴中市"},
                        new City() { Name="遂宁市"},
                        new City() { Name="内江市"},
                        new City() { Name="凉山州"},
                        new City() { Name="攀枝花市"},
                        new City() { Name="乐山市"},
                        new City() { Name="自贡市"},
                        new City() { Name="泸州市"},
                        new City() { Name="雅安市"},
                        new City() { Name="宜宾市"},
                        new City() { Name="资阳市"},
                        new City() { Name="眉山市"},
                        new City() { Name="甘孜州"}
                    } },
                    new Province() { Name="安徽省",Citys=new List<City>()
                    {
                        new City() { Name="芜湖市"},
                        new City() { Name="合肥市"},
                        new City() { Name="六安市"},
                        new City() { Name="宿州市"},
                        new City() { Name="阜阳市"},
                        new City() { Name="安庆市"},
                        new City() { Name="马鞍上市"},
                        new City() { Name="蚌埠市"},
                        new City() { Name="淮北市"},
                        new City() { Name="淮南市"},
                        new City() { Name="宣城市"},
                        new City() { Name="黄山市"},
                        new City() { Name="铜陵市"},
                        new City() { Name="豪州市"},
                        new City() { Name="池州市"},
                        new City() { Name="巢湖市"},
                        new City() { Name="滁州市"}
                    } },
                    new Province() { Name="江西省",Citys=new List<City>()
                    {
                        new City() { Name="南昌市"},
                        new City() { Name="赣州市"},
                        new City() { Name="上饶市"},
                        new City() { Name="吉安市"},
                        new City() { Name="九江市"},
                        new City() { Name="新余市"},
                        new City() { Name="抚州市"},
                        new City() { Name="宜春市"},
                        new City() { Name="景德镇市"},
                        new City() { Name="萍乡市"},
                        new City() { Name="鹰潭市"}
                    } },
                    new Province() { Name="黑龙江省",Citys=new List<City>()
                    {
                        new City() { Name="齐齐哈尔市"},
                        new City() { Name="哈尔滨市"},
                        new City() { Name="大庆市"},
                        new City() { Name="佳木斯市"},
                        new City() { Name="双鸭山市"},
                        new City() { Name="牡丹江市"},
                        new City() { Name="鸡西市"},
                        new City() { Name="黑河市"},
                        new City() { Name="绥化市"},
                        new City() { Name="鹤岗市"},
                        new City() { Name="伊春市"},
                        new City() { Name="七台河市"},
                        new City() { Name="大兴安岭地区"}
                    } },
                    new Province() { Name="吉林省",Citys=new List<City>()
                    {
                        new City() { Name="吉林市"},
                        new City() { Name="长春市"},
                        new City() { Name="白山市"},
                        new City() { Name="延边州"},
                        new City() { Name="白城市"},
                        new City() { Name="松原市"},
                        new City() { Name="辽源市"},
                        new City() { Name="通化市"},
                        new City() { Name="四平市"}
                    } },
                    new Province() { Name="辽宁省",Citys=new List<City>()
                    {
                        new City() { Name="大连市"},
                        new City() { Name="沈阳市"},
                        new City() { Name="丹东市"},
                        new City() { Name="辽阳市"},
                        new City() { Name="葫芦岛市"},
                        new City() { Name="锦州市"},
                        new City() { Name="朝阳市"},
                        new City() { Name="营口市"},
                        new City() { Name="鞍山市"},
                        new City() { Name="抚顺市"},
                        new City() { Name="阜新市"},
                        new City() { Name="盘锦市"},
                        new City() { Name="本溪市"},
                        new City() { Name="铁岭市"}
                    } },
                    new Province() { Name="甘肃省",Citys=new List<City>()
                    {
                        new City() { Name="兰州市"},
                        new City() { Name="天水市"},
                        new City() { Name="庆阳市"},
                        new City() { Name="武威市"},
                        new City() { Name="酒泉市"},
                        new City() { Name="张掖市"},
                        new City() { Name="陇南地区"},
                        new City() { Name="白银市"},
                        new City() { Name="定西地区"},
                        new City() { Name="平凉市"},
                        new City() { Name="嘉峪关市"},
                        new City() { Name="金昌市"},
                        new City() { Name="甘南州"},
                        new City() { Name="宁夏回族自治州"}
                    } },
                    new Province() { Name="青海省",Citys=new List<City>()
                    {
                        new City() { Name="西宁市"},
                        new City() { Name="海西州"},
                        new City() { Name="海东地区"},
                        new City() { Name="海北州"},
                        new City() { Name="果洛州"},
                        new City() { Name="玉树州"},
                        new City() { Name="黄南藏族自治州"}
                    } },
                    new Province() { Name="西藏省",Citys=new List<City>()
                    {
                        new City() { Name="拉萨市"},
                        new City() { Name="山南地区"},
                        new City() { Name="林芝地区"},
                        new City() { Name="日喀则地区"},
                        new City() { Name="阿里地区"},
                        new City() { Name="昌都地区"},
                        new City() { Name="那曲地区"}
                    } },
                    new Province() { Name="海南省",Citys=new List<City>()
                    {
                        new City() { Name="三亚市"},
                        new City() { Name="海口市"},
                        new City() { Name="琼海市"},
                        new City() { Name="文昌市"},
                        new City() { Name="东方市"},
                        new City() { Name="昌江县"},
                        new City() { Name="陵水县"},
                        new City() { Name="乐东县"},
                        new City() { Name="保亭县"},
                        new City() { Name="五指山市"},
                        new City() { Name="澄迈县"},
                        new City() { Name="万宁市"},
                        new City() { Name="儋州市"},
                        new City() { Name="临高县"},
                        new City() { Name="白沙县"},
                        new City() { Name="安定县"},
                        new City() { Name="琼中县"},
                        new City() { Name="屯昌县"}
                    } },
                    new Province() { Name="台湾省",Citys=new List<City>()
                    {
                        new City() { Name="台北市"},
                        new City() { Name="高雄市"},
                        new City() { Name="台中市"},
                        new City() { Name="新竹市"},
                        new City() { Name="基隆市"},
                        new City() { Name="台南市"},
                        new City() { Name="嘉义市"}
                    } },
                    new Province() { Name="广西壮族自治区",Citys=new List<City>()
                    {
                        new City() { Name="贵港市"},
                        new City() { Name="玉林市"},
                        new City() { Name="北海市"},
                        new City() { Name="南宁市"},
                        new City() { Name="柳州市"},
                        new City() { Name="桂林市"},
                        new City() { Name="梧州市"},
                        new City() { Name="钦州市"},
                        new City() { Name="来宾市"},
                        new City() { Name="河池市"},
                        new City() { Name="百色市"},
                        new City() { Name="贺州市"},
                        new City() { Name="崇左市"},
                        new City() { Name="防城港市"}
                    } },
                    new Province() { Name="内蒙古自治区",Citys=new List<City>()
                    {
                        new City() { Name="赤峰市"},
                        new City() { Name="包头市"},
                        new City() { Name="通辽市"},
                        new City() { Name="呼和浩特市"},
                        new City() { Name="鄂尔多斯市"},
                        new City() { Name="乌海市"},
                        new City() { Name="呼伦贝尔市"},
                        new City() { Name="兴安盟"},
                        new City() { Name="巴彦淖尔盟"},
                        new City() { Name="乌兰察布盟"},
                        new City() { Name="锡林郭勒盟"},
                        new City() { Name="阿拉善盟"}
                    } },
                    new Province() { Name="宁夏回族自治区",Citys=new List<City>()
                    {
                        new City() { Name="银川市"},
                        new City() { Name="吴忠市"},
                        new City() { Name="中卫市"},
                        new City() { Name="石嘴山市"},
                        new City() { Name="固原市"}
                    } },
                    new Province() { Name="新疆维吾尔自治区",Citys=new List<City>()
                    {
                        new City() { Name="乌鲁木齐市"},
                        new City() { Name="伊犁州"},
                        new City() { Name="昌吉州"},
                        new City() { Name="石河子市"},
                        new City() { Name="哈密地区"},
                        new City() { Name="阿克苏地区"},
                        new City() { Name="巴音郭楞州"},
                        new City() { Name="喀什地区"},
                        new City() { Name="塔城地区"},
                        new City() { Name="克拉玛依市"},
                        new City() { Name="和田地区"},
                        new City() { Name="阿勒泰州"},
                        new City() { Name="吐鲁番地区"},
                        new City() { Name="阿拉布尔"},
                        new City() { Name="博尔塔拉州"},
                        new City() { Name="五家渠市"},
                        new City() { Name="克孜勒苏州"},
                        new City() { Name="图木舒克市"}
                    } },
                    new Province() { Name="香港特别行政区",Citys=new List<City>(){new City() { Name= "香港特别行政区" } } },
                    new Province() { Name="澳门特别行政区",Citys=new List<City>(){new City() { Name= "澳门特别行政区" } } },
                });
        }

        /// <summary>
        /// 获取 操作排序，数值越小越先执行
        /// </summary>
        public int Order
        {
            get { return 2; }
        }
    }
}
