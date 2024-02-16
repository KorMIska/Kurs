-- Тестовые данные для таблицы "Менеджеры":
INSERT INTO Managers (manager_id, manager_name, manager_phone, manager_salary) VALUES
(1, 'Иван Иванов', '+1234567890', 50000),
(2, 'Мария Сидорова', '+9876543210', 55000);

-- Тестовые данные для таблицы "Кассиры":
INSERT INTO Cashiers (cashier_id, cashier_name, cashier_phone, cashier_salary, manager_id) VALUES
(1, 'Алексей Петров', '+1112223333', 35000, 1),
(2, 'Елена Козлова', '+4445556666', 38000, 2);

-- Тестовые данные для таблицы "Графики работы":
INSERT INTO Schedules (schedule_id, day, cashier_id) VALUES
(1, 'Понедельник', 1),
(2, 'Вторник', 2),
(3, 'Среда', 1),
(4, 'Четверг', 2),
(5, 'Пятница', 1);

-- Тестовые данные для таблицы "Постоянные клиенты":
INSERT INTO RegularCustomers (customer_id, customer_name, customer_phone, total_purchase_amount) VALUES
(1, 'Анна Новикова', '+9998887777', 1500),
(2, 'Сергей Иванов', '+3334445555', 2000);

-- Тестовые данные для таблицы "Проданные товары":
INSERT INTO SoldItems (sold_item_id, price, sale_date, item_name, customer_id) VALUES
(1, 50, '2024-01-21', 'Товар1', 1),
(2, 30, '2024-01-22', 'Товар2', 2),
(3, 25, '2024-01-23', 'Товар3', 1);

-- Тестовые данные для таблицы "Доступные товары":
INSERT INTO AvailableItems (available_item_id, price, expiration_date, item_name, manager_id) VALUES
(1, 50, '2024-02-01', 'Товар1', 1),
(2, 30, '2024-02-15', 'Товар2', 2),
(3, 25, '2024-01-31', 'Товар3', 1);

-- Тестовые данные для таблицы "Акции":
INSERT INTO Promotions (promotion_id, start_time, end_time, nam, manager_id, customer_id) VALUES
(1, '2024-01-25 10:00:00', '2024-01-28 18:00:00', 'Скидка 10%', 1, 1),
(2, '2024-02-05 12:00:00', '2024-02-10 20:00:00', 'Бесплатная доставка', 2, 2);

-- Тестовые данные для таблицы "Отзывы":
INSERT INTO Reviews (review_id, review_text, review_date, rating, customer_id) VALUES
(1, 'Отличное обслуживание!', '2024-01-22', 5, 1),
(2, 'Товары высокого качества', '2024-01-25', 4, 2);
