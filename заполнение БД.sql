USE course_work;

-- склады
INSERT INTO storage VALUES (1, 'Северный');
INSERT INTO storage VALUES (2, 'Южный');

-- РЦ
INSERT INTO factory VALUES (10, 'Доступен', 600);
INSERT INTO factory VALUES (11, 'Доступен', 480);
INSERT INTO factory VALUES (20, 'Доступен', 420);
INSERT INTO factory VALUES (21, 'Доступен', 360);
INSERT INTO factory VALUES (30, 'Доступен', 480);
INSERT INTO factory VALUES (31, 'Доступен', 600);
INSERT INTO factory VALUES (40, 'Доступен', 360);
INSERT INTO factory VALUES (41, 'Доступен', 420);
INSERT INTO factory VALUES (50, 'Доступен', 480);
INSERT INTO factory VALUES (51, 'Доступен', 480);
INSERT INTO factory VALUES (60, 'Доступен', 540);
INSERT INTO factory VALUES (61, 'Доступен', 720);

-- группы заменимости
INSERT INTO group_change VALUES (1, 10);
INSERT INTO group_change VALUES (1, 11);
INSERT INTO group_change VALUES (2, 20);
INSERT INTO group_change VALUES (2, 21);
INSERT INTO group_change VALUES (3, 30);
INSERT INTO group_change VALUES (3, 31);
INSERT INTO group_change VALUES (4, 40);
INSERT INTO group_change VALUES (4, 41);
INSERT INTO group_change VALUES (5, 50);
INSERT INTO group_change VALUES (5, 51);
INSERT INTO group_change VALUES (6, 60);
INSERT INTO group_change VALUES (6, 61);

-- спецификации
INSERT INTO specification VALUES (0, 'Спецификация пылесоса');
INSERT INTO specification VALUES (1, 'Спецификация эл.части');
INSERT INTO specification VALUES (2, 'Спецификация фильтра');
INSERT INTO specification VALUES (3, 'Спецификация шланга');
INSERT INTO specification VALUES (4, 'Спецификация корпуса');

-- тех.карты
INSERT INTO technological_map VALUES (0, 'Производство пылесоса');
INSERT INTO technological_map VALUES (1, 'Производство эл.части');
INSERT INTO technological_map VALUES (2, 'Производство фильтра');
INSERT INTO technological_map VALUES (3, 'Производство шланга');
INSERT INTO technological_map VALUES (4, 'Производство корпуса');

-- состав тех.карты
INSERT INTO comp_map (Oper_ID, Oper_desc, Oper_time, Next_oper_ID, Map_ID, Fact_ID) VALUES (0, 'Сборка пылесоса', 2, 25, 0, 60);
INSERT INTO comp_map (Oper_ID, Oper_desc, Oper_time, Map_ID, Fact_ID) VALUES (1, 'Подключение пылесоса', 25, 0, 61);
INSERT INTO comp_map (Oper_ID, Oper_desc, Oper_time, Map_ID, Fact_ID) VALUES (2, 'Сборка эл.оборудования', 30, 1, 40);
INSERT INTO comp_map (Oper_ID, Oper_desc, Oper_time, Map_ID, Fact_ID) VALUES (3, 'Сборка фильтра', 30, 2, 50);
INSERT INTO comp_map (Oper_ID, Oper_desc, Oper_time, Map_ID, Fact_ID) VALUES (4, 'Сборка шланга', 15, 3, 10);
INSERT INTO comp_map (Oper_ID, Oper_desc, Oper_time, Map_ID, Fact_ID) VALUES (5, 'Сборка корпуса', 60, 4, 30);

-- номенклатура
INSERT INTO material (Mat_ID, Mat_description) VALUES (0, 'Резиновый шланг');
INSERT INTO material (Mat_ID, Mat_description) VALUES (1, 'Металическая ручка');
INSERT INTO material (Mat_ID, Mat_description) VALUES (2, 'Щётка');

-- сами
INSERT INTO material (Mat_ID, Mat_description, Spec_ID, Map_ID) VALUES (3, 'Шланг', 3, 3);

INSERT INTO material (Mat_ID, Mat_description) VALUES (4, 'Пластиковый корпус');
INSERT INTO material (Mat_ID, Mat_description) VALUES (5, 'Корпус для фильтра');
INSERT INTO material (Mat_ID, Mat_description) VALUES (6, 'Волоконный материал' );
INSERT INTO material (Mat_ID, Mat_description) VALUES (7, 'Компрессор');
INSERT INTO material (Mat_ID, Mat_description) VALUES (8, 'Электродвигатель');
INSERT INTO material (Mat_ID, Mat_description) VALUES (9, 'Ёмкость для пыли');

-- сами
INSERT INTO material (Mat_ID, Mat_description, Spec_ID, Map_ID) VALUES (10, 'Корпус в сборе', 4, 4);

-- сами
INSERT INTO material (Mat_ID, Mat_description, Spec_ID, Map_ID) VALUES (11, 'Фильтр', 2, 2);

-- сами
INSERT INTO material (Mat_ID, Mat_description, Spec_ID, Map_ID) VALUES (12, 'Электрическая часть', 1, 1);

-- сами
INSERT INTO material (Mat_ID, Mat_description, Spec_ID, Map_ID) VALUES (13, 'Пылесос', 0, 0);


-- запасы
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (0, 1, 0); -- Резиновый шланг
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (1, 1, 0); -- Металическая ручка
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (2, 1, 0); -- Щётка
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (3, 1, 0); -- Шланг (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (4, 1, 0); -- Пластиковый корпус
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (5, 1, 0); -- Корпус для фильтра
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (6, 1, 0); -- Волоконный материал
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (7, 1, 0); -- Компрессор
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (8, 1, 0); -- Электродвигатель
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (9, 1, 0); -- Ёмкость для пыли
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (10, 1, 0); -- Корпус в сборе (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (11, 1, 0); -- Фильтр (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (12, 1, 0); -- Электрическая часть (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (13, 1, 0); -- Пылесос (сами)

INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (0, 2, 0); -- Резиновый шланг
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (1, 2, 0); -- Металическая ручка
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (2, 2, 0); -- Щётка
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (3, 2, 0); -- Шланг (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (4, 2, 0); -- Пластиковый корпус
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (5, 2, 0); -- Корпус для фильтра
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (6, 2, 0); -- Волоконный материал
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (7, 2, 0); -- Компрессор
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (8, 2, 0); -- Электродвигатель
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (9, 2, 0); -- Ёмкость для пыли
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (10, 2, 0); -- Корпус в сборе (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (11, 2, 0); -- Фильтр (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (12, 2, 0); -- Электрическая часть (сами)
INSERT INTO contains (Mat_ID, St_ID, Cont_amount) VALUES (13, 2, 0); -- Пылесос (сами)

-- состав спецификаций
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (0, 'Сборка частей Пылесоса', 0, 1, 0, 10);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (1, 'Сборка частей Пылесоса', 0, 1, 0, 9);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (2, 'Сборка частей Пылесоса', 0, 1, 0, 11);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (3, 'Подкл. частей Пылесоса', 1, 1, 0, 12);

INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (4, 'Подкл. Эл.частей', 2, 1, 1, 7);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (5, 'Подкл. Эл.частей', 2, 1, 1, 8);

INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (6, 'Сборка Фильтра', 3, 1, 2, 5);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (7, 'Сборка Фильтра', 3, 1, 2, 6);

INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (8, 'Сборка Шланга', 4, 1, 3, 0);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (9, 'Сборка Шланга', 4, 1, 3, 1);

INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (10, 'Сборка Корпуса', 5, 1, 4, 2);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (11, 'Сборка Корпуса', 5, 1, 4, 3);
INSERT INTO comp_spec (Comp_ID, Comp_desc, Operation_ID, Comp_amount, Spec_ID, Mat_ID) VALUES (12, 'Сборка Корпуса', 5, 1, 4, 4);










