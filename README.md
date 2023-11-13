# Asp.Net Core Api SignalR ile QR Kodlu Sipariş Yönetimi   
AspNet Core 6.0 Api ile Restoranlar İçin Dinamik Bir QR Kodlu Sipariş Yönetimi Sistemi [Murat Yücedağ](https://github.com/MuratYucedag/UdemySignalRProject) - [Udemy](https://www.udemy.com/course/aspnet-core-api-signalr-ile-qr-kodlu-siparis-yonetimi/?couponCode=KASIM2023) 

---

Kullanılan Paketler 

    - DataAccessLayer Katmanı İçin
    
      *Microsoft.EntityFrameworkCore.Tools(6.0.24)

      *Microsoft.EntityFrameworkCore.Design(6.0.24)

      *Microsoft.EntityFrameworkCore.SqlServer(6.0.24)

      *Microsoft.EntityFrameworkCore.Core(6.0.24)
      

    - WebApi Katmanı İçin
    
      *Microsoft.EntityFrameworkCore.Design(6.0.24)



Referans Tablosu 

		  	                 DataAccessLayer --> EntityLayer
                      
		       BusinessLayer --> DataAccessLayer --> EntityLayer
         
        WebAPI --> BusinessLayer --> DataAccessLayer --> EntityLayer


---

*Yeni bir metod yazılacaksa ekstra olarak önce IGenericDal içinde yazılır ve sonra GenericRepository'e yazılır ve içi doldurulur.

