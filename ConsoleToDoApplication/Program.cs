using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int choose=0;
            bool success;
            bool flag=true;
            bool newflag=true;
            List<Card> _cardlist=new List<Card>();
            List<Member> _memberList=new List<Member>();
            // _cardlist=new List<Card>();
            // _memberList=new List<Member>();
            Card card=new Card();
            card.Title="IT";
            card.Content="Pc Format";
            card.cardSize=CardSize.L;
            card.LineType=Line.TODOLine;


            Member member=new Member();
            member.FullName="Ahmet Şükrü";
            card.Member=member;
            card.MemberID=member.MemberID;
            member.Card=card;
            member.CardID=card.CardID;
            Card card2=new Card();

            card2.Title="Sofware";
            card2.Content="Web Application";
            card2.cardSize=CardSize.S;
            card2.LineType=Line.INPROGRESSLine;

            Member member2=new Member();
            member2.FullName="Ayşe Sezer";
            
            card2.Member=member2;
            card2.MemberID=member2.MemberID;
            member2.Card=card2;
            member2.CardID=card2.CardID;
            
            Card card3=new Card();
            card3.Title="Deneme";
            card3.Content="Denemeler";
            card3.cardSize=CardSize.XL;
            card3.LineType=Line.DONELİNE;

            Member member3=new Member();
            member3.FullName="Muhittin Topalak";
            card3.Member=member3;
            member3.Card=card3;
            card3.MemberID=member3.MemberID;
            member3.CardID=card3.CardID;
            
            _cardlist.Add(card);
            _cardlist.Add(card2);
            _cardlist.Add(card3);
            _memberList.Add(member);
            _memberList.Add(member2);
            _memberList.Add(member3);

            Member member4=new Member();
            member4.MemberID=4;
            member4.FullName="Hacı Yakışıklı";

            Member member5=new Member();
            member5.MemberID=5;
            member5.FullName="Gamze Gülmez";
            
            _memberList.Add(member4);
            _memberList.Add(member5);
            
            while(flag)
            {
                flag=true;
                newflag=true;
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.Write("Seçim  :");
                success=int.TryParse(Console.ReadLine(),out choose);
                if(success && choose==1)
                {
                    ListBoard(_cardlist);
                    newflag=ExitProgram(flag,choose);
                }
                else if(success && choose==2)
                {
                    while(newflag)
                    {
                        int selectCard;
                        Card newcard= new Card();
                        Console.WriteLine("*****Kart Eklemek*****\n");
                        Console.Write("Başlık Giriniz                                  :");
                        newcard.Title=Console.ReadLine();
                        Console.Write("İçerik Giriniz                                  :");
                        newcard.Content=Console.ReadLine();
                        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                        success=int.TryParse(Console.ReadLine(), out selectCard);
                    
                        if(selectCard==(int)CardSize.XS)
                        newcard.cardSize=CardSize.XS;
                        else if(selectCard==(int)CardSize.S)
                        newcard.cardSize=CardSize.S;
                        else if(selectCard==(int)CardSize.M)
                        newcard.cardSize=CardSize.M;
                        else if(selectCard==(int)CardSize.L)
                        newcard.cardSize=CardSize.L;
                        else if(selectCard==(int)CardSize.XL)
                        newcard.cardSize=CardSize.XL;
                        else
                            Console.WriteLine("Yanlış bir giriş yaptınız. Lütfen doğru kart numarasını girerek devam ediniz.");

                        if(selectCard>0 && selectCard<6)
                        {

                            Console.WriteLine("Seçmek istediğiniz kişinin parantez içindeki ID numarasını giriniz:");
                            foreach (var item in _memberList)
                            {
                                if(item.CardID==null)
                                {
                                    Console.WriteLine(item.FullName+"("+item.MemberID+")");
                                }
                            }
                            success=int.TryParse(Console.ReadLine(),out choose);
                            for (int i = 0; i<=_memberList.Count-1; i++)
                            {
                                if(choose==_memberList[i].MemberID && _memberList[i].CardID==null)
                                {
                                    newcard.MemberID=_memberList[i].MemberID;
                                    _memberList[i].CardID=newcard.CardID;
                                    newcard.Member=_memberList[i];
                                    _memberList[i].Card=newcard;
                                    _cardlist.Add(newcard);
                                    Console.WriteLine("İşlem başarılı bir şekilde gerçekleştirilmiştir.");

                                    ListBoard(_cardlist);
                                    newflag=ExitProgram(success,choose);
                                    break;
                                   
                                }
                                else if(i==_memberList.Count-1)
                                {
                                        
                                    Console.WriteLine("Hatalı bir giriş yaptınız.");
                                    newflag=ExitProgram(success,choose);
                                }
                            }
                        }
                    }
                    
                }
                else if(success && choose==3)
                {
                    while (newflag)
                    {
                        Console.WriteLine("*****Kart Silmek*****\n");
                        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                        Console.Write("Lütfen kart başlığını yazınız:");
                        string queryTitle=Console.ReadLine();
                        bool check=false;
                        for (int i = _cardlist.Count-1; i >=0; i--)
                        {
                            if(_cardlist[i].Title==queryTitle)
                            {
                                Console.WriteLine("Aşağıda bilgileri yer alan kartı silmek istediğinizden emin misiniz? Silmek için (y) ve vazgeçmek için (n) harflerini kullanınız.");
                                Console.WriteLine("Başlık               :{0}",_cardlist[i].Title);
                                Console.WriteLine("İçerik               :{0}",_cardlist[i].Content);
                                Console.WriteLine("Atanan Kişi          :{0}",_cardlist[i].Member.FullName);
                                Console.WriteLine("Kartın Büyüklüğü     :{0}",_cardlist[i].cardSize);
                                Console.Write("Seçim    :");
                                char chooseletter=Char.Parse(Console.ReadLine());
                                Member getmember=GetMember(_cardlist[i].MemberID,_memberList);
                                if(chooseletter=='y' && getmember!=null)
                                {
                                    getmember.CardID=null;
                                    getmember.Card=null;
                                    _cardlist.Remove(_cardlist[i]);
                                    Console.WriteLine("İşlem başarılı bir şekilde gerçekleştirilmiştir.\n");
                                    check=true;
                                    ListBoard(_cardlist);
                                }
                                else if(chooseletter=='n' && getmember!=null)
                                {
                                    Console.WriteLine("İşlemden vazgeçtiniz.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış bir giriş yaptınız. İşleminiz bittiğinde silme ekranına geri döneceksiniz.");
                                }
                            }
                        }
                        
                        if(check==true)
                            newflag=ExitProgram(success,choose);

                        else if(check==false)
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için : (2)");
                            Console.Write("Seçim    :");
                            success=int.TryParse(Console.ReadLine(),out choose);
                            if(success && choose==1)
                            {
                                Environment.Exit(0);
                            }
                            else if(success && choose==2)
                            {
                                
                            }
                        }
                    }
                }
                else if(success && choose==4)
                {
                    while (newflag)
                    {
                        Console.WriteLine("*****Kart Taşımak*****\n");
                        Console.WriteLine("Öncelikle taşmak istediğiniz kartı seçmeniz gerekiyor.");
                        Console.Write("Lütfen kart başlığını yazınız:\n");
                        string queryTitle=Console.ReadLine();
                        for (int i = _cardlist.Count-1; i >=0; i--)
                        {
                            if(_cardlist[i].Title==queryTitle)
                            {
                                Console.WriteLine("Bulunan Kart Bilgileri:");
                                Console.WriteLine("************************");
                                Console.WriteLine("Başlık               :{0}",_cardlist[i].Title);
                                Console.WriteLine("İçerik               :{0}",_cardlist[i].Content);
                                Console.WriteLine("Atanan Kişi          :{0}",_cardlist[i].Member.FullName);
                                Console.WriteLine("Kartın Büyüklüğü     :{0}",_cardlist[i].cardSize);
                                Console.WriteLine("Line                 :{0}",ConvertLine(_cardlist[i].LineType));
                                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                                Console.WriteLine("(1) TODO");
                                Console.WriteLine("(2) IN PROGRESS");
                                Console.WriteLine("(3) DONE");
                                Console.Write("Seçim    :");
                                success=int.TryParse(Console.ReadLine(),out choose);
                                if(choose>0 && choose<4)
                                {
                                    if(choose==1)
                                        _cardlist[i].LineType=Line.TODOLine;
                                    else if(choose==2)
                                        _cardlist[i].LineType=Line.INPROGRESSLine;
                                    else if(choose==3)
                                        _cardlist[i].LineType=Line.DONELİNE;

                                    ListBoard(_cardlist);
                                    newflag=ExitProgram(success,choose);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Yaptığınız seçim doğru değil. Hatalı bir giriş yaptınız.");
                                    newflag=ExitProgram(success,choose);
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("* Yeniden denemek için : (2)");
                                Console.Write("Seçim    :");
                                success=int.TryParse(Console.ReadLine(),out choose);
                                if(success && choose==1)
                                {
                                    Environment.Exit(0);
                                }
                                else if(success && choose==2)
                                {
                                    
                                }
                                break;
                            }
                        }                     
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış bir giriş yaptınız. Lütfen tekrar deneyiniz.");
                }
            }
        }

        static string ConvertLine(Enum lines)
        {
            string word=string.Empty;
            switch(lines)
            {
                case Line.TODOLine:
                    word="TODO Line";
                    break;
                case Line.INPROGRESSLine:
                    word="IN PROGRESS Line";
                    break;
                case Line.DONELİNE:
                    word="DONE LİNE";
                    break;
            }
            return word;
        }
        static void CardList(Line linesize,List<Card> cardlistcome)
        {
            List<Card> cardlist=new List<Card>();
            foreach (var item in cardlistcome)
            {
                if(item.LineType==linesize)
                cardlist.Add(item);
                else if(item.LineType==linesize)
                cardlist.Add(item);
                else if(item.LineType==linesize)
                cardlist.Add(item);
            }
            if(cardlist.Count>0)
            {
                foreach (var item in cardlist)
                {
                        Console.WriteLine("************************");
                        Console.WriteLine("Başlık       :{0}",item.Title);
                        Console.WriteLine("İçerik       :{0}",item.Content);
                        Console.WriteLine("Atanan Kişi  :{0}",item.Member.FullName);
                        Console.WriteLine("Büyüklük     :{0}",item.cardSize);
                        Console.WriteLine("-----------\n");
                }
            }
            else
            {
                Console.WriteLine("************************");
                Console.WriteLine("~ BOŞ ~\n");
            }
        }

        static bool ExitProgram(bool flag, int choose)
        {
            while(flag)
            {
             Console.WriteLine("------------------------");
             Console.WriteLine("Lütfen bir seçim yapınız.");
             Console.WriteLine("Ana menüye dönmek için: (1)");
             Console.WriteLine("Programı sonlandırmak için: (2)");
             Console.Write("Seçim   :");
             flag=int.TryParse(Console.ReadLine(), out choose);
             if(flag && choose==1)
             {
                 flag=false;
             }
             else if(flag && choose==2)
             {
                 Environment.Exit(0);
             }
             else 
                 Console.WriteLine("Yanlış bir giriş yaptınız. Lütfen tekrar bir seçim yapınız.");
            }

            return flag;
        }

        public static List<Card> GetAll(List<Card> _cardlist)
        {
            return _cardlist;
        }

        static void ListBoard(List<Card> _cardlist)
        {
                    Console.WriteLine("*****Board Listelemek*****\n");
                    Console.WriteLine();
                    Console.WriteLine("TODO Line");
                    CardList(Line.TODOLine,_cardlist);
                    Console.WriteLine("IN PROGRESS Line");
                    CardList(Line.INPROGRESSLine,_cardlist);
                    Console.WriteLine("DONE Line");
                    CardList(Line.DONELİNE,_cardlist);
        }
        static Member GetMember(int id, List<Member> memberlist)
        {
            foreach (var item in memberlist)
            {
                if(item.MemberID==id)
                {
                    return item;
                }

            }
            return null;
        }
    }
}
