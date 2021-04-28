--Производственный заказ
UPDATE custom SET Mat_ID = @a, Cus_amount = @b;
command.Parameters.Add("@a", MySqlDbType.VarChar).Value = textBoxIDProd;
command.Parameters.Add("@b", MySqlDbType.Int32).Value = numericUpDownAmount;
/* Рассчет стоимости?
Дата - now();
ID заказа = autoincrement
Статус заказа - ? Создан (нужен ли?)
*/

--размещение производственного заказа должно порождать цепочку запросов для "бронирования"
--запасов на складах и времени работы РЦ


--заказ закупок
UPDATE contains SET Cont_amount = @a
WHERE Mat_ID = @b AND St_ID = @c;
command.Parameters.Add("@a", MySqlDbType.VarChar).Value = numericUpDownMaterialID;
command.Parameters.Add("@b", MySqlDbType.Int32).Value = numericUpDownStorageID;
command.Parameters.Add("@c", MySqlDbType.Int32).Value = numericUpDownAmount;
--Заказ закупок как бы обновляет таблицу запасов, увеличивая кол-во имеющихся товаров создавая иллюзиб закупки
--необходимо ввести проверку на вводимое кол-во продукции (кол-во после закупки > запасов)

--заказ перемещения. Предполагает выравнивание запасов одного и того же продукта на складах
--для этого вероятно стоит организовать процедуру для рассчета среднего арифметического всех запасов данного продукта на всех складах
--и затем обновлять таблицу запасов, "укладывая" в каждый склад ~равное(+/- 1) кол-во продуктов с одинаковым ID

--Управление РЦ.
UPDATE factory SET Fact_status = @a, Fact_time = @b
command.Parameters.Add("@a", MySqlDbType.VarChar).Value = textBoxStatus;
command.Parameters.Add("@b", MySqlDbType.Int32).Value = textBoxTime;
--Обеспечивает управление статусом и временем работы Цехов
--Можно как увеличить, так и уменьшить оставшееся время его работы.
