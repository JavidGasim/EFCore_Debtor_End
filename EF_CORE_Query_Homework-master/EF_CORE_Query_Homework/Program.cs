using EF_CORE_Query_Homework.Contexts;

var context = new DebtorDBContext();

//2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
//var a = context.Debtors.Where(d => d.Email.EndsWith("rhyta.com") || d.Email.Contains("dayrep.com"));
//foreach (var d in a)
//{
//    Console.WriteLine(d);
//}


//  3) Yashi 26-dan 36-ya qeder olan borclulari cixartmag
//var a = context.Debtors.Where(d => (2024 - d.BirthDay.Year) >= 26 && (2024 - d.BirthDay.Year <= 36));
//foreach (var d in a)
//{
//    Console.WriteLine(d);
//}

//  4) Borcu 5000-den cox olmayan borclularic cixartmag
//var a = context.Debtors.Where(d => d.Debt <= 5000);
//foreach (var d in a)
//{
//    Console.WriteLine(d.Debt);
//}

//  5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2-den cox 7 reqemi olan borclulari cixartmaq
//var a = context.Debtors.Where(d => d.FullName.Length > 18 && d.Phone.Contains("7"));

//foreach (var d in a)
//{
//    Console.WriteLine(d);
//}


//  7) Qishda anadan olan borclulari cixardmaq 
//var a = context.Debtors.Where(d => d.BirthDay.Month == 12 || d.BirthDay.Month == 1 || d.BirthDay.Month == 2);
//foreach (var d in a)
//{
//    Console.WriteLine(d.BirthDay);
//}

//  8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
//var average = context.Debtors.Average(d => d.Debt);
//var a = context.Debtors.Where(d => d.Debt > average).OrderByDescending(d => d.FullName).ThenBy(b => b.Debt);

//foreach (var d in a)
//{

//    Console.WriteLine(d);
//}

//  9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq
//var a = context.Debtors.Where(d => d.Phone.Contains("8") == false);
//foreach (var d in a)
//{
//    Console.WriteLine(d.FullName.Split(' ')[1].Trim() + d.FullName.Split(' ')[2].Trim());
//    Console.WriteLine(2024 - d.BirthDay.Year);
//    Console.WriteLine(d.Debt + "\n");
//}

//  11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek
//var a = context.Debtors.ToList()
//                .Where(d => d.FullName.Split(' ')[0].Trim().ToLower().Distinct().Count(c => d.FullName.Split(' ')[0].Trim().ToLower().Count(x => x == c) >= 3) > 0 ||
//                d.FullName.Split(' ')[2].Trim().ToLower().Distinct().Count(c => d.FullName.Split(' ')[2].Trim().ToLower().Count(x => x == c) >= 3) > 0);

//foreach (var d in a.ToList())
//{
//    Console.WriteLine(d);
//}

//  13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq
//var a = context.Debtors.GroupBy(d => d.BirthDay).OrderByDescending(d => d.Count()).Select(d => d.Key).First();

//Console.WriteLine(a);

//14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq
//List<int> ints = new List<int>();
//int check = 0;
//var a = context.Debtors.OrderByDescending(d => d.Debt).Take(5);
//foreach (var b in a)
//{
//    Console.WriteLine(b);

//}

//  15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq
//int a = context.Debtors.Sum(d => d.Debt);
//Console.WriteLine(a);

//  16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
//var a = context.Debtors.Where(d => d.BirthDay.Year >= 1939 && d.BirthDay.Year <= 1945);
//foreach (var d in a)
//{
//    Console.WriteLine(d);
//}

//  18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq

//int check = 0;
//foreach(var d in context.Debtors.ToList())
//{
//    if (HasDuplicateDigits(d.Phone)) 
//    {
//        Console.WriteLine(d);
//    }
//}

//bool HasDuplicateDigits(string Phone)
//{
//    foreach (char symbol in Phone)
//    {
//        if (Phone.Count(c => c == symbol) > 1)
//        {
//            check++;

//        }
//    }
//    if(check >= 1) 
//    {
//        return true;
//    }
//    else { return false; }
//}

//  19)Tesevvur edek ki, butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler. Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq
//var a = context.Debtors.Where(d => (d.BirthDay.Month - DateTime.Now.Month) * 500 > d.Debt ).ToList();

//foreach (var d in a)
//{
//    Console.WriteLine(d);
//}

// 20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq
//var a = context.Debtors.Where(d => d.FullName.Contains("s") && d.FullName.Contains("m") && d.FullName.Contains("i") && d.FullName.Contains("l") && d.FullName.Contains("e")).ToList();

//foreach (var d in a)
//{
//    Console.WriteLine(d);
//}