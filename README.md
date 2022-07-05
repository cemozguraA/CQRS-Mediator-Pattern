# CQRS-Mediator-Pattern
#CQRS &amp; Mediator Pattern .Net 6 Örneği

## Command Query Responsibility Segregation (CQRS)

 ##### Kısaca açıklamak gerekirse, komut ve sorgu kodlarını birbirinden ayrı tutarak ilerleyen bir tasarım şeklidir.
- Command : Veri değişikliği olacak durumlar için (update,insert,delete) ele aldığımız kısımdır.
- Query : Veriyi getirmek istediğimiz durumlar için ele aldığımız kısımdır.

##Mediator
##### Mediator pattern ile nesneler arasındaki iletişim, bir aracı nesnesinde kapsüllenir. Nesneler artık birbirleriyle doğrudan değil, aracılar aracılığıyla iletişim kurar. Bu, iletişim kuran nesneler arasındaki bağımlılıkları azalır ve böylece eşleşmeyi azaltır. Bu konu üzerinde spesifik herkesin verdiği uçak ve kule örneği vardır. Uçaklar tek bir merkezden inişlerini sağlar ve karmaşıklıklar engellenir.

##Not
 ##### Mimari yapıyı en basit şekilde anlatmaya çalıştım. Kullanımları ve örnekleri proje içinde temiz bir şekilde yazdım.
 
 #####Proje içerisine ekleneck nugetpackler
 - #####MediatR 
 - #####MediatR.Extensions.Microsoft.DependencyInjection
