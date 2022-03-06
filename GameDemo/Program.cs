using GameDemo;
using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using MernisServiceReference1;

Member member1 = new Member();
member1.NationalityId = 0123456789;
member1.FirstName = "Burcu";
member1.LastName = "Taş";
member1.DateOfBirth = new DateTime(2002, 3, 17);
member1.Crash = 1000;


MemberManager memberManager = new MemberManager(new MemberCheckManager());
memberManager.Add(member1);
memberManager.Update(member1);
memberManager.Delete(member1);

IGameSalesService buyGold = new BuyGold();
IGameSalesService buySilver = new BuySilver();
IGameSalesService buyMoney = new BuyMoney();


ICampaignsService newMemberCampaign = new NewMemberCampaign();
ICampaignsService summerCampaign = new SummerCampaign();
ICampaignsService newYearCampaign = new NewYearCampaign();


SalesManager salesManager = new SalesManager();
salesManager.Sales(buyGold, newMemberCampaign, member1);
salesManager.Sales(buyMoney, summerCampaign, member1);







Console.ReadLine();




