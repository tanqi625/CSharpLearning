using System;

namespace CSharpEnum
{

    enum E_QQState
    {
        online,
        offline,
        invisible,
    }
    enum E_Starbucks
    {
        middleCup = 35,
        largeCup = 40,
        venti = 43,
    }
    enum E_gender
    {
        /// <summary>
        /// 男性
        /// </summary>
        male,
        /// <summary>
        /// 女性
        /// </summary>
        female,

    }
    enum E_attackPoint
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        male = 50,
        female = 150,
        warrior = 20,
        hunter = 120,
        monk = 200,
    }
    enum E_defencePoint
    {
        /// <summary>
        /// 防御力
        /// </summary>
        male = 100,
        female = 20,
        warrior = 100,
        hunter = 30,
        monk = 10, 
    }
    enum E_career
    {
        warrior,
        /// <summary>
        /// 战士
        /// </summary>
        hunter,
        /// <summary>
        /// 猎人
        /// </summary>
        monk,
        /// <summary>
        /// 法师
        /// </summary>
    }
    enum E_skils
    {
        charge,
        /// <summary>
        /// 冲锋
        /// </summary>
        feignDeath,
        /// <summary>
        /// 装死
        /// </summary>
        ArcaneBlast,
        /// <summary>
        /// 奥术冲锋
        /// </summary>
    }
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("plz choose a QQ state");
            int stateNum = Convert.ToInt32(Console.ReadLine());
            E_QQState qqState = (E_QQState)stateNum;
            switch (qqState)
            {
                case E_QQState.online:
                    Console.WriteLine("在线");
                    break;
                case E_QQState.offline:
                    Console.WriteLine("离线");
                    break;
                case E_QQState.invisible:
                    Console.WriteLine("隐身");
                    break;
            }
            Console.WriteLine("您要买什么?（middleCup/largeCup/venti）");
            string type = Console.ReadLine();
            E_Starbucks drinkType = (E_Starbucks)Enum.Parse(typeof(E_Starbucks), type);
            switch (drinkType)
            {
                case E_Starbucks.middleCup:
                    Console.WriteLine("您购买了{0}咖啡，消费{1}元。",type,(int)E_Starbucks.middleCup);
                    break;
                case E_Starbucks.largeCup:
                    Console.WriteLine("您购买了{0}咖啡，消费{1}元。", type, (int)E_Starbucks.largeCup);
                    break;
                case E_Starbucks.venti:
                    Console.WriteLine("您购买了{0}咖啡，消费{1}元。", type, (int)E_Starbucks.venti);
                    break;

            }
            Console.WriteLine("请选择性别 男/女 , 职业 战士/猎人/法师");
            string genderStr = Console.ReadLine();
            string careerStr = Console.ReadLine();
            E_gender Gender = (E_gender)(Enum.Parse(typeof(E_gender),genderStr));
            E_career Career = (E_career)(Enum.Parse(typeof(E_career), careerStr));
            switch (Gender)
            {
                case E_gender.male:
                    switch (Career)
                    {
                        
                        case E_career.warrior:
                            int CurrentAttackPoint = (int)E_attackPoint.male + (int)E_attackPoint.warrior;
                            int CurrentDefencePoint = (int)E_defencePoint.male + (int)E_defencePoint.warrior;
                            Console.WriteLine("你选择了“{0} {1}”，攻击力：{2}，防御力：{3}，技能：{4}",genderStr,careerStr,CurrentAttackPoint,CurrentDefencePoint,((E_skils)(int)E_career.warrior).ToString());
                            break;
                        case E_career.hunter:
                            CurrentAttackPoint = (int)E_attackPoint.male + (int)E_attackPoint.hunter;
                            CurrentDefencePoint = (int)E_defencePoint.male + (int)E_defencePoint.hunter;
                            Console.WriteLine("你选择了“{0} {1}”，攻击力：{2}，防御力：{3}，技能：{4}", genderStr, careerStr, CurrentAttackPoint, CurrentDefencePoint, ((E_skils)(int)E_career.hunter).ToString());
                            break;
                        case E_career.monk:
                            CurrentAttackPoint = (int)E_attackPoint.male + (int)E_attackPoint.monk;
                            CurrentDefencePoint = (int)E_defencePoint.male + (int)E_defencePoint.monk;
                            Console.WriteLine("你选择了“{0} {1}”，攻击力：{2}，防御力：{3}，技能：{4}", genderStr, careerStr, CurrentAttackPoint, CurrentDefencePoint, ((E_skils)(int)E_career.monk).ToString());
                            break;
                    }

                    break;
                case E_gender.female:
                    switch (Career)
                    {

                        case E_career.warrior:
                            int CurrentAttackPoint = (int)E_attackPoint.female + (int)E_attackPoint.warrior;
                            int CurrentDefencePoint = (int)E_defencePoint.female + (int)E_defencePoint.warrior;
                            Console.WriteLine("你选择了“{0} {1}”，攻击力：{2}，防御力：{3}，技能：{4}", genderStr, careerStr, CurrentAttackPoint, CurrentDefencePoint, ((E_skils)(int)E_career.warrior).ToString());
                            break;
                        case E_career.hunter:
                            CurrentAttackPoint = (int)E_attackPoint.female + (int)E_attackPoint.hunter;
                            CurrentDefencePoint = (int)E_defencePoint.female + (int)E_defencePoint.hunter;
                            Console.WriteLine("你选择了“{0} {1}”，攻击力：{2}，防御力：{3}，技能：{4}", genderStr, careerStr, CurrentAttackPoint, CurrentDefencePoint, ((E_skils)(int)E_career.hunter).ToString());
                            break;
                        case E_career.monk:
                            CurrentAttackPoint = (int)E_attackPoint.female + (int)E_attackPoint.monk;
                            CurrentDefencePoint = (int)E_defencePoint.female + (int)E_defencePoint.monk;
                            Console.WriteLine("你选择了“{0} {1}”，攻击力：{2}，防御力：{3}，技能：{4}", genderStr, careerStr, CurrentAttackPoint, CurrentDefencePoint, ((E_skils)(int)E_career.monk).ToString());
                            break;
                    }
                    break;


            }

            Console.ReadKey();





        }
    }
}