# NewTestCase

- Service ve managerleri vewritabanından çekeceğimi düşünerek eklemiştim, maile istinaden yorum satırına aldım.
- Entity katmanında jsondaki datayı deserialize edebilmek için uyumlu modeller oluşturdum.
- Helper da ise; tekrar olmaması adına get metodunu consumerda tanımladım.
- Mainpage controller'da itemlisttekileri view'e gönderdim ve kategoriler dinamik gelmesi için için Viewbag ile view'e taşıdım.
- Sayfalama yapabilmesi ViewModelde yer alan pageview model ile sayfalama ile gönderdim, tıklanılan sayfa sayısını, toplam sayıyı ve sayfada kaç adet olacaksa constructorında tanımlayarak newlendiğinde oluşmasını sağladım.
- Detail de sadece DetailNew modelime deserialize ederek view'e taşıdım ve gösterdim.

