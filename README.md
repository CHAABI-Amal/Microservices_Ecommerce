Microservices
1. BasketAPI
Description : Gestion du panier d'achat des utilisateurs.
Fonctionnalités :
Ajouter, modifier et supprimer des articles.
Suivi en temps réel du panier.
📂 Chemin : BasketAPI/

2. OrderingAPI
Description : Gestion des commandes utilisateurs.
Fonctionnalités :
Créer et suivre les commandes.
Mettre à jour les statuts des commandes.
Intégration avec des systèmes de paiement.
📂 Chemin : OrderingAPI/

Technologies Utilisées
ASP.NET Core : Framework pour les microservices.
Docker : Conteneurisation des services.
RabbitMQ : Bus de messages pour la communication entre services.
Swagger : Documentation des APIs.
Screenshots
BasketAPI - Gestion du Panier

OrderingAPI - Gestion des Commandes

RabbitMQ - Connexions

Swagger - BasketAPI

Swagger - OrderingAPI

Instructions d'installation
Cloner le repo :

bash
Copy code
git clone https://github.com/CHAABI-Amal/Microservices_Ecommerce.git
cd Microservices_Ecommerce
Exécuter les Microservices :

BasketAPI :
bash
Copy code
cd BasketAPI
dotnet run
OrderingAPI :
bash
Copy code
cd OrderingAPI
dotnet run
Démarrer RabbitMQ :
Assurez-vous que RabbitMQ est installé localement.

Accéder aux APIs :

BasketAPI Swagger : http://localhost:5120/swagger
OrderingAPI Swagger : http://localhost:5126/swagger
Contact
CHAABI Amal

GitHub : CHAABI-Amal
Email : example@email.com
