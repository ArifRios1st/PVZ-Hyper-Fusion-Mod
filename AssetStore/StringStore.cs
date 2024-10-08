#if USE_TRANSLATE
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using System.Text.RegularExpressions;

namespace PVZ_Hyper_Fusion.AssetStore
{
    public static class StringStore
    {
        internal static Dictionary<string, string> stringsDict = new Dictionary<string, string>();

        public static Dictionary<string, string> translationStringRegex = new Dictionary<string, string>()
        {
            {@"第(\d+)已完成","Level {0} completed"},
            {@"^(\d+)轮","{0} Rounds"},
            {@"快捷键：(\d+)","Press：{0}"},
            {@"场上敌人数量：(\d+)","Zombies：{0}"},
            {@"难度：(\d+)","Difficulty：{0}"},

            {@"^设置([^\s]+)数","Set {0}"},
            {@"^允许([^\s]+)","Enable {0}"},
            {@"^禁用([^\s]+)","Disable {0}"},

            {@"^图鉴————(.*)","The Suburban Almanac — {0}"},
            {@"主菜单(.*)","Main Menu{0}"},
            {@"当前大小：([^\s]+)","Current Size: {0}"},
            {@"UI高度匹配：([^\s]+)","UI Height Match: {0}"},
            {@"当前设置：([^\s]+)","Current: {0}"},
            {@"切换全屏(\d+)\*(\d+)","Fullscreen {0}*{1}"},
            {@"查看(.*)","View {0}"},
            {@"返回(.*)","Back to {0}"},
            {@"回到(.*)","Back to {0}"},
            {@"^按F键切换全屏\s+局内按Esc键暂停游戏\s+","Press F to switch to full screen\r\nPress Esc to pause the game\r\nDifficulty 4 and 5 Ashes no longer ignore armor\r\nDifficulty 4 reduce damage by 30%\r\nDifficulty 5 reduce damage by 60%, charm probability halved"},
            {@"^开发人员名单\s+","Developer List\r\nProgrammer, Lead:蓝飘飘fly\r\nAnimation:蓝飘飘fly\r\nArt:机鱼吐司、蓝蝶\r\nVideo Production:梦珞呀\r\nAnimation Assistance:射命丸文"},
            {@"^确定退出吗？\s+","Are you sure you want to exit?\r\nProgress will not be saved!\r\nExcept for Survival Mode."},
            {@"^自定义关卡使用条款，开发者在此声明：\s+","Custom Level Terms of Use, Developer's Statement:\r\nCustom levels are created by players themselves. If a map violates laws or regulations, or infringes on the rights of others, please immediately exit and delete the level. Playing the level implies that the player agrees to bear any risks and responsibilities associated with using custom levels."},
            {@"^地图编辑器使用条款，开发者在此声明：\s+","Map Editor Terms of Use, Developer's Statement:\r\nThe editor is only for normal level creation use. Any behavior that violates laws and regulations or infringes on the rights of others is strictly prohibited. Players agree to assume the risks and responsibilities associated with using the editor."},
            {@"^按Tab切换鼠标位置格子类型\s+","Press Tab to switch the mouse position grid type.\r\nHold A (D) to move the mouse and switch to grass (dirt).\r\nPress C to save; the saved level will take effect in the custom levels."},
            {@"^保存关卡完毕！前往自定义关卡游玩\s+","Level saved successfully! Go to play custom levels.\r\nYou can also share the levels you created with your friends to challenge them.\r\nThe location of the level file is as follows:\r\nC:\\Users[Your Username]\\AppData\\LocalLow\\LanPiaoPiao\\PlantsVsZombiesRH\\CustomBlock.json"},

            {@"^第(\d+)关","Level {0}"},
            {@"^黑夜：([^\s]+)", "Night：{0}" },
            {@"^白天：([^\s]+)", "Day：{0}" },
            {@"^泳池：([^\s]+)", "Pool：{0}" },
            {@"^浓雾：([^\s]+)", "Fog：{0}" },

            {@"^目标场景：(6路)?([^\s]*)", "Scene：{0} {1}" },

            {@"^经典塔防(\d+)?","Tower Defense {0}"},
            {@"^生存(模式)?(：)([^\s]+)","Survival {0}{1}{2}"},
            {@"^冒险模式(：)?(?:第)?(\d+)(?:关)?","Adventure Mode{0}{1}"},
            {@"^旅行体验(：)?(?:第)?(\d+)(?:关)?","Travel Experience {0}{1}"},
            {@"^经典塔防([\s\n]*?(?:[\s：]))([^\s：]+)", "Tower Defense{0}{1}"},
            {@"^十旗挑战([\s\n]*?(?:[\s：]))([^\s：]+)", "10 Wave{0}{1}"},
            {@"^超级([^\s：挑战]+)(：|\n)?(挑战关卡|挑战)?([\d]*)?","{0} {1}{2} {3}"},
            {@"^10.(\d+)版本前瞻\n超级预览版","Version 10.{0} Preview\nSuper Preview Edition"},
            {@"^1、([^\s]+)","1. {0}"},
            {@"^2、([^\s]+)","2. {0}"},
            {@"^3、([^\s]+)","3. {0}"},
            {@"^选择(\d+)","Select {0}"},

            {@"^决战([^\s]+)！","Final Battle {0}"},
        };

        public static Dictionary<string, string> translationString = new Dictionary<string, string>()
        {
            {"敬请期待","Stay tuned"},
            {"其它","Other"},
            {"确定","OK"},
            {"接受","Accept"},
            {"返回","Return"},
            {"关闭","Close"},
            {"取消","Cancel"},
            {"再次尝试","Try Again."},
            {"游戏结束","Game Over"},
            {"重新开始","Restart"},
            {"返回游戏","Resume"},
            {"需要","Needed"},
            {"不需要","Not needed"},
            {"下一页","Next"},
            {"上一页","Previous"},
            {"轮已经完成","round"},
            {"模式","mode"},
            {"保存关卡","Save Level"},
            {"更换场景","Change Scene"},
            {"开启斗蛐蛐","Start Fight"},
            {"开始/关闭出怪","Start/Stop Spawn"},
            {"保存植物阵容","Save Plant Lineup"},
            {"加载植物阵容","Load Plant Lineup"},
            {"填充随机植物","Fill with Random Plants"},
            {"全自动斗蛐蛐","Fully Automatic Fight"},
            {"刷新选项","Refresh"},
            {"放弃增益","Give Up Buffs"},

            {"游戏完全免费，点击这里关注作者蓝飘飘fly，获取最新更新动态","The game is completely free. Click here to follow the author 蓝飘飘fly to get the latest updates."},
            {"点击这里关注画师机鱼吐司","Click here to follow the artist 机鱼吐司"},

            {"设置","Settings"},
            {"再按一次确定","Press OK again"},
            {"一键通关泳池版本","Clear Pool mode"},
            {"一键通关所有关卡","Clear all levels"},
            {"重置所有关卡","Reset all levels"},
            {"调整相机投影大小","Camera size"},
            {"修改画布匹配","Canvas Size"},
            {"诸神是否需要手套","Do the gods need gloves?"},

            {"确定重新开始吗？","Are you sure\nyou want to restart?"},
            {"选择你的植物","Choose Your Plants"},
            {"请选择禁用的植物","Please select the plants to disable"},
            {"一起摇滚吧！","Let's Rock !"},
            {"主菜单","Main Menu"},
            {"查看图鉴","Look Almanac"},
            {"重选上次卡牌","Reselect last card"},
            {"加入出怪(Q)","Add Zombie (Q)"},
            {"移除出怪(W)","Remove Zombie (W)"},


            {"音乐","Music"},
            {"音效","SFX"},
            {"游戏速度","Game Speed"},
            {"切换鼠标反转","Invers Mouse"},
            {"更改屏幕缩放","Zoom"},
            {"切换小地图","Minimap"},
            {"可以优化性能","Perfomance Impact"},
            {"时停","Slow Mode"},
            {"修改格子只对大地图有效","Modifying the grid is only effective for large maps"},


            {"索引","Index"},
            {"植物","Plants"},
            {"僵尸","Zombies"},
            {"菜单","Menu"},

            {"前往设置僵尸","Set Zombies"},
            {"阳光","Sunlight"},
            {"旗帜","Flag"},
            {"增益","Buff"},
            {"当前增益","Current Buff"},

            {"简单模式","Easy Mode"},
            {"正常模式","Normal Mode"},
            {"普通模式","Standard Mode"},
            {"困难模式","Hard Mode"},
            {"极难模式","Extreme Mode"},
            {"你确定？","Are you sure?"},


            {"数据异常","Data anomalies"},
            {"你可以获得随机1种究极植物\r\n但你将面对更强大的僵尸","You can get a random ultimate plant\r\nBut you will face stronger zombies"},
            {"我是僵尸","I am a zombie"},
            {"通关挑战模式解锁配方","Unlock Recipes by Completing Challenge Mode"},
            {"该配方仅旅行模式可用","This recipe is only available in travel mode"},
            {"只能融合小喷菇！","Can only fuse Puff-shroom!"},
            {"不能在水上融合！","Cannot fuse on water!"},
            {"不能在陆地上融合！","Cannot be fused on land!"},
            {"尚未解锁配方","Recipe not unlocked yet"},

            {"更多的僵尸要来了！","More zombies are coming!"},
            {"一大波僵尸正在接近！","A HUGE WAVE OF ZOMBIES IS APPROACHING!"},

            {"试试把豌豆种到向日葵上面","Try planting Peashooter on top of Sunflowers"},
            {"手里拿着植物时可以融合的植物会发光","Plants that can be fused will glow when held in hand"},
            {"坚果融合后可以回满血哦","After the nuts are fused, you can restore your health."},
            {"手套可以自由移动或融合植物","Gloves can move freely or merge plants"},
            {"礼盒可开出基础植物，亦可作为任意基础植物进行融合","The gift box can open basic plants, \nand can also be used as any basic plant for fusion"},
            {"僵尸掉落的铁桶可以放到豌豆射手和坚果墙上","The buckets dropped by zombies \ncan be placed on the Pea Shooter and Wall-Nut"},
            {"高坚果作为紫卡只能放在坚果墙上","As a purple card, the Tall-Nut can only be placed on the Wall-Nut"},
            {"一个格子里可以放3个小喷菇","You can put 3 Puff-shroom in one grid."},
            {"小秘密：小喷菇+向日葵=阳光菇","Little secret: Puff-shroom + Sunflower = Sun-shroom"},
            {"肥料可用于给植物回血，更多用法自行探索","Fertilizer can be used to restore the blood of plants, \nmore uses can be explored by yourself"},
            {"毁灭大喷菇要手动点击哦","To destroy the giant mushroom, you need to click it manually."},
            {"橄榄帽可以放到高坚果上","Football helmet can be placed on Tall-Nut"},
            {"忧郁菇作为紫卡只能放在大喷菇上","Gloom-shroom, as a purple card, can only be placed on the Fume-shroom"},
            {"听说了吗？有的睡莲头上会长植物","Have you heard that Lily Pad have plants growing on their heads?"},
            {"传说有些僵尸被刺红温了更容易受伤","Legend has it that some zombies are \nmore vulnerable to injury when they are stabbed red."},
            {"地刺王作为紫卡只能放在地刺上","As a purple card, \nthe EarthSpikerock can only be placed on the Spikeweed."},
            {"猫尾草作为紫卡只能放在睡莲上","Cattail, as a purple card, can only be placed on water Lily Pad."},
            {"路灯花会为周围5*5范围格子提供1点光照等级","Plantern provides 1 point of light level to the surrounding 5x5 grid."},
            {"光系植物随着所在格子的光照等级增加而变强","Light-type plants become stronger as the light level of the grid they are on increases."},
            {"木锤会送一只僵尸归西","The Wooden Hammer will send a zombie to its doom."},
            {"试试将磁力菇吸到的物体放到磁力南瓜或磁力杨桃上","Try placing the objects attracted by the Magnet-shroom onto the Magnetic Pumpkin or Magnetic Starfruit."},
            {"注意到磁力菇边上白色的线了吗，将他们都连起来","Did you notice the white lines next to the Magnet-shroom? Connect them all together."},

            {"超级樱桃射手+樱桃机枪射手","Super Cherry Peashooter + Cherry Gatling Pea"},
            {"火爆窝瓜+窝炬","Hot squash + squid"},
            {"魅惑菇+魅惑菇","Hypno-shroom + Hypno-shroom"},
            {"超级大喷菇+超级魅惑菇","Super Scaredy-shroom + Super Charm Mushroom"},
            {"超级大嘴花+樱桃大嘴花","Super Big Mouth Chomper + Cherry Chomper"},
            {"小心你没见过的僵尸！","Watch out for zombies you haven't seen before!"},
            {"豌豆+樱桃+樱桃","Peashooter + Cherry Bomb + Cherry Bomb"},
            {"豌豆+坚果+大嘴花","Peashooter + Wall-Nut + Chomper"},
            {"大喷菇+胆小菇+魅惑菇","Fume-shroom + Scaredy-shroom + Hypno-shroom"},
            {"这一关只能种植或融合小喷菇！","In this level, you can only grow or fuse Puff-shroom!"},
            {"火炬+辣椒+辣椒","Torchwood + Jalapeno + Jalapeno"},
            {"水草+窝瓜+三线","Tangle Kelp + Squash + Threepeater"},
            {"击败僵尸以获取阳光","Defeat zombies to get sunlight"},
            {"大喷菇+寒冰菇+毁灭菇","Fume-shroom + Ice-shroom + Doom-shroom"},
            {"杨桃+路灯花+磁力菇","Starfruit + Plantern + Magnet-shroom"},
            {"仙人掌+南瓜+三叶草","Cactus + Pumpkin + Clover"},
            {@"杨桃+磁力仙人掌  ","Starfruit + Magnet Clover"},
            {@"大喷菇+寒冰忧郁菇  ","Super Fume-shroom + Ice Gloom-shroom"},
            {@"南瓜+磁力三叶草  ","Pumpkin + Magnet Clover"},

            {"错误：尝试生成不存在的植物！","Error: Attempting to spawn a plant that doesn't exist!"},
            {"错误：尝试生成不存在的种植预览！","Error: Trying to generate a planting preview that doesn't exist!"},

            {"已解超级樱桃机枪射手，樱桃机枪+超级樱桃射手","Solved Super Cherry Gatling Pea, Cherry Gatling Pea + Super Cherry Peashooter"},
            {"已解锁火爆窝炬，火爆窝瓜+窝炬","Unlocked The Hot Squash Torchwood, Hot Squash + Squash Torchwood"},
            {"已解锁樱桃战神，樱桃大嘴花+超级大嘴花","Unlocked Cherry War God, Cherry Chomper + Super Big Mouth Chomper"},
            {"已解锁究极大喷菇，超级大喷菇+超级魅惑菇","Unlocked the Ultimate Giant Ejection Mushroom, Super Giant Ejection Mushroom + Super Charm Mushroom"},
            {"已解锁全部植物","Unlocked all plants"},
            {"此类植物仅特定模式使用","This plant is only used in certain conditions"},

            {"困难","Hard"},
            {"无尽","Endless"},
            {"（困难）","（Hard）"},
            {"（无尽）","（Endless）"},

            {"白天","Day"},
            {"黑夜","Night"},
            {"泳池","Pool"},
            {"旅行","Travel"},
            {"浓雾","Fog"},
            {"屋顶","Roof"},
            {"大地图","Large Map"},
            {"6路","6 Way"},
            {"种子雨","It's Raining Seeds"},
            {"自定义关卡","Custom levels"},
            {"关卡编辑器","Level editor"},
            {"合理密植","Reasonable Planting Density"},
            {"二爷战争","Second Master War"},
            {"套娃","Nested Dolls"},
            {"全是套娃","All Are Nested Dolls"},
            {"谁能笑到最后","Who Can Laugh Last"},
            {"空袭","Airstrike"},
            {"黑夜舞会","Night Dance"},
            {"撑杆舞会","Pole Dance"},
            {"泳池激斗","Pool Battle"},
            {"无尽塔防","Endless \nTower Defense"},
            {"植物僵尸","Plant Zombies"},
            {"随机植物","Random Plants"},
            {"随机僵尸","Random Zombies"},
            {"全员随机","All Random"},
            {"超级随机","Super Random"},
            {"究极随机","Ultimate Random"},
            {"随机塔防","Random Tower Defense"},
            {"诸神","The Gods"},
            {"诸神：升级","Gods: Upgrade"},
            {"胆小菇之梦","Dream of Scaredy-shroom"},
            {"排山倒海","Overwhelms"},
            {"坚不可摧","Unbreakable"},
            {"旅行植物","Travel Plants"},
            {"旅行词条","Travel Entries"},

            {"挑战","Challenge"},
            {"挑战关卡","Challenge Levels"},

            {"冒险模式","Adventure Mode"},
            {"挑战模式","Challenge Mode"},
            {"解谜模式","Puzzle Mode"},
            {"生存模式","Survival Mode"},
            {"高级挑战","Advanced\nChallenge"},
            {"十旗挑战","10 Wave\nChallenge"},
            {"旅行体验","Travel\nExperience"},
            {"迷你游戏","Mini Games"},


            {"解锁究极樱桃战神，超级大嘴花+樱桃大嘴花","Unlock the Ultimate Cherry War God, Super Big Mouth Flower + Cherry Big Mouth Flower"},
            {"解锁究极樱桃机枪，樱桃机枪+超级樱桃射手","Unlock the Ultimate Cherry Machine Gun, Cherry Machine Gun + Super Cherry Shooter"},
            {"解锁究极大喷菇，超级大喷菇+超级魅惑菇","Unlock the Ultimate Giant Ejection Mushroom, Super Giant Ejection Mushroom + Super Charm Mushroom"},
            {"解锁究极窝炬，超级火炬+火爆窝瓜","Unlock the Ultimate Torch, Super Torch + Explosive Torch"},
            {"解锁究极杨桃，超级杨桃+磁力仙人掌","Unlock Ultimate Starfruit, Super Starfruit + Magnetic Cactus"},
            {"解锁究极忧郁菇，超级大喷菇+寒冰忧郁菇","Unlock the Ultimate Melancholy, Super-sized Ejecta and Ice Melancholy"},

            {"魅帝召唤间隔减为10秒","The interval between summoning the Emperor of Charm is reduced to 10 seconds"},
            {"魅帝能召唤究极僵尸","The Emperor can summon the ultimate zombie"},
            {"毁灭机枪不再需要休息","The Destroyer no longer requires a rest"},
            {"毁灭机枪每轮都能发射大子弹","The Destroyer Machine Gun fires large bullets per round"},
            {"阳光帝果每次都能回满血","Sunshine Emperor Fruit can restore full health every time"},
            {"阳光帝果单次受伤降为10点","Sunshine Emperor Fruit's single damage is reduced to 10 points"},
            {"玄钢地刺王伤害*5","Dark Steel Thorn King Damage*5"},
            {"玄钢地刺王现在获得95%减伤","Darksteel Thorn now gains 95% damage reduction"},
            {"阳光价值提高一个等级","Increase the sunlight value by one level"},
            {"手套冷却减半","Gloves cooldown halved"},
            {"卡牌冷却减半","Card cooldown halved"},
            {"锤子冷却变为1/10","Hammer cooldown reduced to 1/10"},
            {"每回合开始时在每行生成一个魅惑舞王冰车","At the beginning of each round, a Charming Dancer Ice Car is generated in each row"},
            {"获得2000阳光，然后使你的阳光翻倍","Gain 2000 sun, then double your sun"},
            {"火焰豌豆类会对僵尸附加红温效果","Flame peas will add a red temperature effect to zombies"},
            {"红温增伤幅度增至150%","Red temperature damage increased to 150%"},
            {"手套不再有冷却时间","Gloves no longer have a cooldown"},
            {"冰锥的穿透次数增加到10次","Increased the number of times the ice spike penetrates to 10 times"},
            {"冰锥的对冻结的单位造成伤害提升至10倍","Ice cone's damage to frozen units increased to 10 times"},
            {"超级杨桃的流星间隔cd减半","Super Starfruit's meteor interval CD is halved"},
            {"全场默认最高光照等级","The default maximum light level for the entire venue"},
            {"激光南瓜的僚机增加至3个","Laser Pumpkin's wingmen increased to 3"},
            {"激光南瓜的僚机可以对地攻击","Laser Pumpkin's wingman can carry out ground attacks"},
            {"黑曜石高坚果受到寒冰菇效果回血10000，火爆辣椒效果回满血","Obsidian Tall Nuts recover 10,000 HP when affected by Ice Mushrooms, and recover full HP when affected by Fiery Chili Peppers"},
            {"黑曜石高坚果会代替左右两株植物受伤","Obsidian Tall Nut will take damage instead of the two plants on the left and right."},
            
            {"大幅强化究极樱桃战神的攻击距离","Greatly enhances the attack range of the Ultimate Cherry Warrior"},
            {"使得究极樱桃战神能免疫一切爆炸","Makes the Ultimate Cherry War God immune to all explosions"},
            {"究极樱桃机枪现在免疫樱桃爆炸","Ultra Cherry Machine Gun is now immune to cherry explosions"},
            {"降低究极樱桃机枪的攻击间隔至1秒","Reduced the attack interval of the Ultra Cherry Machine Gun to 1 second"},
            {"提升究极大喷菇的攻击力至300","Increases the attack power of Ultra-Giant Shroom to 300"},
            {"提升究极大喷菇的冻结速度为3倍","Increases the freezing speed of Ultra-Giant Enchantment to 3 times"},
            {"降低究极窝炬生成窝瓜需要的子弹数至10","Reduced the number of bullets required to spawn a Squash for the Ultimate Meat Torch to 10"},
            {"究极窝炬每次可以生成两个窝瓜","The Ultimate Squash can generate two Wogua at a time."},
            {"降低究极杨桃个攻击间隔至0.5秒","Reduced the attack interval of Ultimate Starfruit to 0.5 seconds"},
            {"究极杨桃的子弹攻击力不再有上限","The attack power of Ultra Starfruit's bullets no longer has an upper limit"},
            {"究极忧郁菇亡语伤害增加到1000000","Increased Ultra Melancholy's deathrattle damage to 1,000,000"},
            {"究极忧郁菇现在会吸收爆炸伤害然后把爆炸能量释放出来","Ultra Melancholy now absorbs explosion damage and releases the explosion energy"},


            { "伤害", "Damage" },
            { "秒杀", "Instant Kill" },
            { "秒", "sec" },
            { "阳光产量", "Sun Production" },
            { "花费", "Cost" },
            { "冷却时间", "Cooldown" },
            { "融合配方", "Recepie" },
            { "特点", "Feature" },
            { "韧性", "HP" },
            { "冻结值", "Freeze" },


            { "樱桃射手", "Cherry-bomb Shooter"},
            { "大嘴花", "Chomper"},
            { "魅惑菇", "Hypno-Shroom"},
            { "大喷菇", "Fume-Shroom"},
            { "火炬", "Torchwood"},
            { "窝草", "Tangle Kelp"},
            { "南瓜", "Pumpkin"},
            { "杨桃", "Starfruit"},

            {"我是僵尸！","I am a zombie!"},
            {"我也是僵尸！","I'm a zombie too!"},
            {"你能吃了它吗！","Can you eat it!"},
            {"雷区！","Minefield!"},
            {"完全傻了！","Totally stunned!"},
            {"卑鄙的低矮植物！","Despicable\nlowly plant!"},
            {"QQ弹弹！","QQ bounce!"},
            {"当代女大学生！","Modern Female\nCollege Student!"},
            {"胆小菇前传！","Prequel of\nthe Scaredy-shroom!"},
            {"冰冻关卡！","Frozen Level!"},
            {"初见泳池！","First Encounter\nat the Pool!"},
            {"三三得九！","Three times three\nequals nine!"},
            {"嗯？","Hmm?"},
            {"尸愁之路！","Path of the Undead!"},
            {"严肃火炬！","Serious Torch!"},
            {"你是僵尸","You are a zombie"},
            {"你也是僵尸！","You are \na zombie too!"},
            {"看星星！","Look at the stars!"},
            {"万磁王！","Magneto!"},
            {"十面埋伏！","Ambush from\nall sides!"},
            {"马奇诺防线！","Maginot Line!"},
        };

        internal static void Init()
        {
            FileLoader.LoadStrings();
        }

        internal static void Reload()
        {
            FileLoader.LoadStrings();
        }

        public static string TranslateText(string originalText, bool isLog = false)
        {
            if (string.IsNullOrEmpty(originalText))
            {
                if (isLog)
                    Log.LogError("Text Null or Empty");

                return string.Empty;
            }

            if (translationString.ContainsKey(originalText))
            {
                if (isLog)
                    Log.LogDebug("Text found in translationString");
                return translationString[originalText];
            }

            // Regex-based dynamic translation
            foreach (var entry in translationStringRegex)
            {
                var regex = new Regex(entry.Key);
                if (regex.IsMatch(originalText))
                {
                    // Extract dynamic parts from the original text
                    var match = regex.Match(originalText);
                    int groupCount = match.Groups.Count;

                    if (isLog)
                        Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

                    // List to hold formatted dynamic parts
                    List<string> dynamicParts = new List<string>();

                    // Loop through each group and determine its translation
                    for (int i = 1; i < groupCount; i++)
                    {
                        string groupValue = match.Groups[i].Value;
                        string translatedValue = translationString.ContainsKey(groupValue)
                            ? translationString[groupValue]
                            : groupValue;
                        dynamicParts.Add(translatedValue);
                    }

                    // Format the output string with dynamic parts
                    return string.Format(entry.Value, dynamicParts.ToArray());
                }
            }

            if (isLog)
                Log.LogDebug("Text not translated");
            return originalText;
        }

        public static void TranslateTextTransform(Transform baseTransform, bool isAutoTextContainer = false, bool isLog = false)
        {
            if (!baseTransform)
                return;

            Transform textTransform = baseTransform.transform.Find("text");
            if (textTransform)
            {
                TextMeshPro textTMP = textTransform.GetComponent<TextMeshPro>();
                if (textTMP)
                {
                    textTMP.text = TranslateText(textTMP.text, isLog);
                    textTMP.autoSizeTextContainer = isAutoTextContainer;
                }

                TextMeshProUGUI textTMPUGUI = textTransform.GetComponent<TextMeshProUGUI>();
                if (textTMPUGUI)
                {
                    textTMPUGUI.text = TranslateText(textTMPUGUI.text, isLog);
                    textTMPUGUI.autoSizeTextContainer = isAutoTextContainer;
                }

                UnityEngine.UI.Text textUI = textTransform.GetComponent<UnityEngine.UI.Text>();
                if (textUI)
                {
                    textUI.text = TranslateText(textUI.text, isLog);
                }

                Transform shadowTransform = textTransform.transform.Find("shadow");
                if (shadowTransform)
                {
                    TextMeshPro shadowTMP = shadowTransform.GetComponent<TextMeshPro>();
                    if (shadowTMP)
                    {
                        shadowTMP.text = TranslateText(shadowTMP.text, isLog);
                        shadowTMP.autoSizeTextContainer = isAutoTextContainer;
                    }

                    TextMeshProUGUI shadowTMPUGUI = shadowTransform.GetComponent<TextMeshProUGUI>();
                    if (shadowTMPUGUI)
                    {
                        shadowTMPUGUI.text = TranslateText(shadowTMPUGUI.text, isLog);
                        shadowTMPUGUI.autoSizeTextContainer = isAutoTextContainer;
                    }

                    UnityEngine.UI.Text shadowUI = shadowTransform.GetComponent<UnityEngine.UI.Text>();
                    if (shadowUI)
                    {
                        shadowUI.text = TranslateText(shadowUI.text, isLog);
                    }
                }
            }

            Transform text1Transform = baseTransform.transform.Find("text1");
            if (text1Transform)
            {
                TextMeshPro textTMP = text1Transform.GetComponent<TextMeshPro>();
                if (textTMP)
                {
                    textTMP.text = TranslateText(textTMP.text, isLog);
                    textTMP.autoSizeTextContainer = isAutoTextContainer;
                }

                TextMeshProUGUI textTMPUGUI = text1Transform.GetComponent<TextMeshProUGUI>();
                if (textTMPUGUI)
                {
                    textTMPUGUI.text = TranslateText(textTMPUGUI.text, isLog);
                    textTMPUGUI.autoSizeTextContainer = isAutoTextContainer;
                }

                UnityEngine.UI.Text textUI = text1Transform.GetComponent<UnityEngine.UI.Text>();
                if (textUI)
                {
                    textUI.text = TranslateText(textUI.text, isLog);
                }

            }

        }
        public static void LogAll()
        {
            Log.LogInfo("Logging all StringStore entries.");
            Log.LogInfo("Regex Entries: {0}", translationStringRegex.Count);
            Log.LogInfo("String Entries: {0}", translationString.Count);
        }
    }
}
#endif