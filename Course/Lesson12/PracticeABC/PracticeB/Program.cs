using System;

namespace PracticeB {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }

        class Product {
            string name;
            int price;
            string description;

            Product(string name, int price, string description) {
                this.name = name;
                this.price = price;
                this.description = description;
            }
        }

        class Shop {
            string category;
            List<string> products;

            Shop(string category, List<string> products) {
                this.category = category;
                this.products = products;
            }
        }

        class Order {
            int id;
            List<string> items;
            int total;

            Order(int id, List<string> items, int total) {
                this.id = id;
                this.items = items;
                this.total = total;
            }
        }

        class User {
            string name;
            string email;
            int purchases;

            User(string name, string email, int purchases) {
                this.name = name;
                this.email = email;
                this.purchases = purchases;
            }
        }

        class Cart {
            List<string> cart_content;

            Cart(List<string> cart_content) {
                this.cart_content = cart_content;
            }
        }

        class Shipping {
            string method;
            double price;
            int estimated_days;

            Shipping(string method, double price, int estimated_days) {
                this.method = method;
                this.price = price;
                this.estimated_days = estimated_days;
            }
        }

        class Payment
        {
            string method;
            string status;

            Payment(string method, string status) {
                this.method = method;
                this.status = status;
            }
        }

        class Review
        {
            string product;
            int rating;
            string comment;

            Review(string product, int rating, string comment) {
                this.product = laptop;
                this.rating = rating;
                this.comment = comment;
            }
        }

        class Discount
        {
            string product;
            string discount;

            Discount(string product, string discount) {
                this.product = product;
                this.discount = discount;
            }
        }

        class Address
        {
            string type;
            string address;

            Address(string type, string addres) {
                this.type = type;
                this.address = addres;
            }
        }
    }
}
