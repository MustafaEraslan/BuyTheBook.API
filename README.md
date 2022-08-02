# BuyTheBook.API

BuyTheBook Store: 
Hi BuyTheBook is one of the cool online book stores. In here we sell the books with the best prices to the best matching customers. Matching is the key driver of our business so pls implement another cool matching API for our clients (Either mobile or web). 
Requirements: 
User Service: 
•	There must be a user registration service.  
•	A user can register to the system and of course log in afterwards.  
•	You do not have to implement e2e security. But if we can see JWT based authentication there of course that could be very positive. 
Book Stock Service: 
•	There must be a stock tracking service where you can add, remove, update and delete books.  
Recommendation Service: 
•	We care about matching a lot. So, in here we would like you to design a recommendation service. This service recommends some books to the user whenever user requests to get some recommendation.  
•	Please keep that in mind a book has two main criteria for being offered. One of them is the kind and the other one is the NSPF.  
•	NSPF is a calculation like “(number of sell) * (pricing factor)”. Our customers intent to buy always the cheapest book(s). 
•	If a kind of a book matches the interest of the user, then this book(s) can be recommended. And pls offer up to 5 books to the customer. 
Order Service(Bonus): 
•	A customer can buy one or more books over an order service. 
•	This service is optional so if you can create one your chances can be increased. 
 
So please think simply and focus on the customer's needs. You can extend, modify or complete any part of the requirements but it is better not to destroy the main goal.  
Also, we prefer to use the services in a containerized cluster.  Better to use a NoSQL DB and it would be great if you could implement GraphQL but it is optional.  
It could be very nice to have APIs in action so pls send your postman collection or similar. 
Choose your favorite language, framework or libs. Design your architecture with no doubt. We are all fine with any tech stack. Please share your github repo with us for the review process. A meaningful git history is very much welcome. 
