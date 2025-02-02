# LINQ Join Kullanımı Örnek Projesi

## Açıklama
Bu proje, C# programlama dilinde **LINQ** kullanarak iki liste arasında **JOIN (birleştirme) işlemi** yapmayı göstermektedir.

Projede **Authors (Yazarlar)** ve **Books (Kitaplar)** olmak üzere iki liste bulunmaktadır. Bu listeler, **AuthorId** üzerinden birbirleriyle ilişkilendirilmiştir. LINQ kullanılarak, her kitabın yazarıyla birlikte eşleştirilmesi sağlanmaktadır.

## Kullanılan Teknolojiler
- **C# (C-Sharp)**
- **.NET**
- **LINQ (Language Integrated Query)**

## Kod Açıklaması
Kod içerisinde **Authors** ve **Books** listeleri tanımlanmıştır:

```csharp
List<Authors> authors = new List<Authors>()
{
    new Authors {Name = "George Orwell", AuthorId = 1},
    new Authors {Name = "Stefan Zweig", AuthorId = 2},
    new Authors {Name = "Haruki Murakami", AuthorId = 3},
};

List<Books> books = new List<Books>()
{
    new Books { Title = "1984", AuthorId = 1, BookId = 1},
    new Books {Title = "Satranç", AuthorId = 2, BookId = 2},
    new Books {Title = "Olağanüstü Bir Gece", AuthorId = 2,BookId = 3},
    new Books {Title = "İmkansızın Şarkısı", AuthorId = 3, BookId = 4}
};
```

Yukarıdaki listeler **AuthorId** üzerinden eşleştirilerek birleştirilmiştir:

```csharp
var joinedBooks = from book in books
                  join author in authors on book.AuthorId equals author.AuthorId
                  select new
                  {
                      AuthorName = author.Name,
                      BookTitle = book.Title
                  };
```

Sonuçlar ekrana aşağıdaki formatta yazdırılmaktadır:

```csharp
foreach (var book in joinedBooks)
{
    Console.WriteLine($"{book.BookTitle} yazarı -> {book.AuthorName}");
}
```

## Örnek Çıktı
Kod çalıştırıldığında ekrana şu formatta sonuçlar yazdırılır:

```
1984 yazarı -> George Orwell
Satranç yazarı -> Stefan Zweig
Olağanüstü Bir Gece yazarı -> Stefan Zweig
İmkansızın Şarkısı yazarı -> Haruki Murakami
```

## Çalıştırma Talimatları
1. **Proje dosyasını açın** (Visual Studio veya uygun bir C# geliştirme ortamında)
2. **Program.cs** dosyasını çalıştırın
3. **Ekrana kitap ve yazar eşleşmelerinin yazdırıldığını gözlemleyin**

## Katkıda Bulunma
Bu projeye katkıda bulunmak için lütfen **pull request** gönderin veya hataları bildiriniz. 😊

