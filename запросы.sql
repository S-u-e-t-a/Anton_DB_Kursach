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
command.Parameters.Add("@a", MySqlDbType.Int32).Value = numericUpDownMaterialID;
command.Parameters.Add("@b", MySqlDbType.Int32).Value = numericUpDownStorageID;
command.Parameters.Add("@c", MySqlDbType.Int32).Value = numericUpDownAmount;
--Заказ закупок как бы обновляет таблицу запасов, увеличивая кол-во имеющихся товаров создавая иллюзиб закупки
--необходимо ввести проверку на вводимое кол-во продукции (кол-во после закупки > запасов)

--заказ перемещения.
int amount1 = SELECT Cont_amount FROM contains WHERE St_ID = @b AND Mat_ID = @a;
int amount2 = SELECT Cont_amount FROM contains WHERE St_ID = @c AND Mat_ID = @a;
amount1 = amount1 + numericUpDownAmount.Value;
amount2 = amount2 - numericUpDownAmount.Value;
UPDATE contains SET Cont_amount = amount1 WHERE St_ID = @b AND Mat_ID = @a;
UPDATE contains SET Cont_amount = amount2 WHERE St_ID = @c AND Mat_ID = @a;
command.Parameters.Add("@a", MySqlDbType.Int32).Value = numericUpDownMaterialID;
command.Parameters.Add("@b", MySqlDbType.Int32).Value = numericUpDownStorageIDTo;
command.Parameters.Add("@с", MySqlDbType.Int32).Value = numericUpDownStorageIDFrom;
command.Parameters.Add("@d", MySqlDbType.Int32).Value = numericUpDownAmount;

--Управление РЦ.
UPDATE factory SET Fact_status = @a, Fact_time = @b
command.Parameters.Add("@a", MySqlDbType.VarChar).Value = textBoxStatus;
command.Parameters.Add("@b", MySqlDbType.Int32).Value = textBoxTime;
--Обеспечивает управление статусом и временем работы Цехов
--Можно как увеличить, так и уменьшить оставшееся время его работы.
