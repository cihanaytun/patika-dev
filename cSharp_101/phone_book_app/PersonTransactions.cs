namespace  phone_book_app
{
   public class PersonTransactions 
   {
    

        List<PersonCard> PersonCardBook = new List<PersonCard>();
        public PersonTransactions()
        {
            PersonCardBook.Add(new PersonCard("Polis","Hattı","155"));
            PersonCardBook.Add(new PersonCard("İtfaye","Hattı","110"));
            PersonCardBook.Add(new PersonCard("Sağlık","Hattı","112"));
            PersonCardBook.Add(new PersonCard("Jandarma","Hattı","156"));
            PersonCardBook.Add(new PersonCard("Sahil güvenlik","Hattı","158"));
        }




        // Add New Number
        public void AddPerson()
        {
            PersonCard person = new();

            System.Console.Write("Lütfen isim giriniz              : ");
            person.Name = Console.ReadLine().ToLower();

            System.Console.Write("Lütfen soyisim giriniz           : ");
            person.Surname = Console.ReadLine().ToLower();

            System.Console.Write("Lütfen telefon numarası giriniz  : ");
            person.Phone = Console.ReadLine();

            PersonCardBook.Add(person);       
        }



        // Remove Number
        public void RemoveNumber()
        {
            string nameOrSurname;
            int numberDelete = 2;
            while (numberDelete == 2)
            {
                Console.WriteLine(" Lütfen telefonunu silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                nameOrSurname = Console.ReadLine();

                foreach (var item in PersonCardBook)
                {               
                    if ((PersonCardBook.IndexOf(item) == PersonCardBook.Count -1) && !(nameOrSurname.ToLower() == item.Name.ToLower() || nameOrSurname.ToLower() == item.Surname.ToLower()))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri  bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine(" * Yeniden denemek için      : (2)");

                        numberDelete = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine(item.Name +" "+item.Surname + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)" );

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            Console.WriteLine(item.Name + " " + item.Surname + " kişi silindi");
                            PersonCardBook.RemoveAt(PersonCardBook.IndexOf(item));
                            numberDelete = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }




       //Update Number
        public void UpdateNumber()
        {
            string nameOrSurname;
            int numberUpdate = 2;

            while (numberUpdate == 2)
            {
                Console.WriteLine("Lütfen güncellemk silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                nameOrSurname = Console.ReadLine();

                foreach (var item in PersonCardBook)
                {
                    if ((PersonCardBook.IndexOf(item) == PersonCardBook.Count -1) && !(nameOrSurname.ToLower() == item.Name.ToLower() || nameOrSurname.ToLower() == item.Surname.ToLower()))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                        Console.WriteLine(" * Yeniden denemek için              : (2)");

                        numberUpdate = Convert.ToInt32(Console.ReadLine());

                    }
                    //error
                    else 
                    {
                        Console.WriteLine(item.Name + " " + item.Surname + " kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            Console.WriteLine("Lütfen yeni isim giriniz              : ");
                            item.Name = Console.ReadLine();
                            Console.WriteLine("Lütfen yeni soyisim giriniz           : ");
                            item.Surname = Console.ReadLine();
                            Console.WriteLine("Lütfen yeni telefon numarası giriniz  : ");
                            item.Phone = Console.ReadLine();    
                            Console.WriteLine(item.Name + " " + item.Surname + "  " + item.Phone + " kişi olarak güncellendi");
                            
                            numberUpdate = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }



       // Person List
        public void PersonList()
        {
            Console.WriteLine("  Telefon Rehberi \n**********************************************");  
            foreach (var item in PersonCardBook)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Phone);
                Console.WriteLine("---------");
            }              
        }





       // Search Person
        public void SerachPerson()
        {
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.:");
            Console.WriteLine(" ***************************************");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");   


            int searchType = Convert.ToInt32(Console.ReadLine());
        
            if (searchType == 1)
            {
                Console.WriteLine("İsim veya soyisime göre arama yapmak için isim ya da soyisim giriniz");
                string nameOrSurname=Console.ReadLine();

                foreach (var item in PersonCardBook)
                {
                    if ((PersonCardBook.IndexOf(item) == PersonCardBook.Count -1) && !(nameOrSurname.ToLower() == item.Name.ToLower() || nameOrSurname.ToLower() == item.Surname.ToLower()))
                    {
                        if (!PersonCardBook.Contains(item))
                        {
                            Console.WriteLine("Aranan krtiterlere uygun kişi rehberde bulunamadı.");                  
                        }
                    }
                    else 
                    {
                        Console.WriteLine("İsim: " + item.Name + "\n Soyisim: " + item.Surname + "\n Telefon Numarası: " + item.Phone);                    
                    }
                }
            }
            else if (searchType == 2)
            {
                Console.WriteLine(" Telefon numarasına göre arama yapmak için telefon numarasını giriniz");
                string phoneNumber = Console.ReadLine();

                foreach (var item in PersonCardBook)
                {
                    if ((PersonCardBook.IndexOf(item) == PersonCardBook.Count - 1) && !(phoneNumber.ToLower() == item.Phone.ToLower()))
                    {
                        if (!PersonCardBook.Contains(item))
                        {
                            Console.WriteLine("Aranan krtiterlere uygun kişi rehberde bulunamadı.");                  
                        }        
                        else
                        {
                            continue;
                        }                
                    }
                    else if (phoneNumber == item.Phone)
                    {
                        Console.WriteLine("İsim: " + item.Name + "\n Soyisim: " + item.Surname + "\n Telefon Numarası: " + item.Phone);                                          
                    }

                }

            }        
        }




   }
}