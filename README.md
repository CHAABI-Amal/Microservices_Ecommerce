# **Microservices E-commerce**

Ce projet est un exemple d'architecture Microservices pour un système E-commerce. Il est composé de deux microservices principaux :

- **Basket API** : Gestion des paniers d'achat.  
- **Ordering API** : Gestion des commandes.  

Il utilise **RabbitMQ** comme broker de messages pour la communication entre services et propose des interfaces documentées avec **Swagger**.

---

## **Table des matières**

- **📸 Screenshots**
- **⚙️ Architecture**
- **🛠️ Microservices**
- **🔧 Technologies utilisées**
- **🚀 Instructions d'installation**
- **📧 Contact**

---

## **📸 Screenshots**

### **Gestion du Panier - BasketAPI**  
![img13](https://github.com/user-attachments/assets/9faced87-3c3c-4df3-9b12-8dbf3822790a)


### **Commandes - OrderingAPI**  
![img14](https://github.com/user-attachments/assets/57c66076-ba32-4295-8637-2afdfd5dd38c)


### **RabbitMQ - Connexions**  
![img15](https://github.com/user-attachments/assets/b3882743-2ed8-4b90-b604-fcdd1944fdf5)


### **Swagger - Basket API**  
![img16](https://github.com/user-attachments/assets/bbcb4b82-dfc0-4ae0-a15c-6c189b27c92c)


### **Swagger - Ordering API**  
![img17](https://github.com/user-attachments/assets/8d536a87-b64c-4de9-a7ec-45a95a51b128)



## **⚙️ Architecture**

L'architecture est divisée en deux microservices indépendants :  

- **Basket API** : Responsable de la gestion du panier.  
- **Ordering API** : Responsable des commandes.  

Les services communiquent via **RabbitMQ**.

---

## **🛠️ Microservices**

### **Basket API**  
- **URL** : `http://localhost:5120/swagger`  
- **Fonctionnalités** :  
   - Ajouter des articles au panier.  
   - Modifier la quantité des articles.  
   - Supprimer un article du panier.  

- **Endpoints Swagger** :  
   - `GET /Basket` : Obtenir le panier.  
   - `POST /Basket/updateQuantity/{productId}`  
   - `DELETE /Basket/removeItem/{productId}`  

---

### **Ordering API**  
- **URL** : `http://localhost:5126/swagger`  
- **Fonctionnalités** :  
   - Voir l'état des commandes.  
   - Traiter les commandes existantes.  

- **Endpoints Swagger** :  
   - `GET /Order` : Liste des commandes.  

---

## **🔧 Technologies Utilisées**

- **ASP.NET Core** : Développement des APIs.  
- **RabbitMQ** : Message Broker pour communication inter-services.  
- **Swagger** : Documentation des APIs.  
- **Docker** : Optionnel pour la conteneurisation.  

---

## **🚀 Instructions d'installation**

### **Clone le repo** :
```bash
git clone https://github.com/CHAABI-Amal/Microservices_Ecommerce.git
cd Microservices_Ecommerce
