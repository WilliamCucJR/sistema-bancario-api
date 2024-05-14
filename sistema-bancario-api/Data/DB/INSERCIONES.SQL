-- Inserción de departamentos
INSERT ALL 
INTO Departamento (ID, Nombre_del_departamento) VALUES (1, 'Alta Verapaz')
INTO Departamento (ID, Nombre_del_departamento) VALUES (2, 'Baja Verapaz')
INTO Departamento (ID, Nombre_del_departamento) VALUES (3, 'Chimaltenango')
INTO Departamento (ID, Nombre_del_departamento) VALUES (4, 'Chiquimula')
INTO Departamento (ID, Nombre_del_departamento) VALUES (5, 'El Progreso')
INTO Departamento (ID, Nombre_del_departamento) VALUES (6, 'Escuintla')
INTO Departamento (ID, Nombre_del_departamento) VALUES (7, 'Guatemala')
INTO Departamento (ID, Nombre_del_departamento) VALUES (8, 'Huehuetenango')
INTO Departamento (ID, Nombre_del_departamento) VALUES (9, 'Izabal')
INTO Departamento (ID, Nombre_del_departamento) VALUES (10, 'Jalapa')
INTO Departamento (ID, Nombre_del_departamento) VALUES (11, 'Jutiapa')
INTO Departamento (ID, Nombre_del_departamento) VALUES (12, 'Petén')
INTO Departamento (ID, Nombre_del_departamento) VALUES (13, 'Quetzaltenango')
INTO Departamento (ID, Nombre_del_departamento) VALUES (14, 'Quiché')
INTO Departamento (ID, Nombre_del_departamento) VALUES (15, 'Retalhuleu')
INTO Departamento (ID, Nombre_del_departamento) VALUES (16, 'Sacatepéquez')
INTO Departamento (ID, Nombre_del_departamento) VALUES (17, 'San Marcos')
INTO Departamento (ID, Nombre_del_departamento) VALUES (18, 'Santa Rosa')
INTO Departamento (ID, Nombre_del_departamento) VALUES (19, 'Sololá')
INTO Departamento (ID, Nombre_del_departamento) VALUES (20, 'Suchitepéquez')
INTO Departamento (ID, Nombre_del_departamento) VALUES (21, 'Totonicapán')
INTO Departamento (ID, Nombre_del_departamento) VALUES (22, 'Zacapa')
SELECT * FROM dual;


-- Municipios del departamento de Alta Verapaz
INSERT ALL 
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (1, 'Cobán', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (2, 'Santa Cruz Verapaz', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (3, 'San Cristóbal Verapaz', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (4, 'Tactic', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (5, 'Tamahú', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (6, 'San Miguel Tucurú', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (7, 'Panzós', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (8, 'Senahú', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (9, 'San Pedro Carchá', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (10, 'San Juan Chamelco', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (11, 'San Agustín Lanquín', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (12, 'Santa María Cahabón', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (13, 'Chisec', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (14, 'Chahal', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (15, 'Fray Bartolomé de las Casas', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (16, 'Santa Catalina La Tinta', 1)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (17, 'Raxruhá', 1)
SELECT * FROM dual;

-- Municipios del departamento de Baja Verapaz
INSERT ALL 
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (18, 'Salamá', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (19, 'San Miguel Chicaj', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (20, 'Rabinal', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (21, 'Cubulco', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (22, 'Granados', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (23, 'Santa Cruz el Chol', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (24, 'San Jerónimo', 2)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (25, 'Purulhá', 2)
SELECT * FROM dual;


-- Municipios del departamento de Chimaltenango
INSERT ALL 
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (26, 'Chimaltenango', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (27, 'San José Poaquil', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (28, 'San Martín Jilotepeque', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (29, 'San Juan Comalapa', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (30, 'Santa Apolonia', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (31, 'Tecpán', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (32, 'Patzún', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (33, 'San Miguel Pochuta', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (34, 'Patzicía', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (35, 'Santa Cruz Balanyá', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (36, 'Acatenango', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (37, 'San Pedro Yepocapa', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (38, 'San Andrés Itzapa', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (39, 'Parramos', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (40, 'Zaragoza', 3)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (41, 'El Tejar', 3)
SELECT * FROM dual;

-- Municipios del departamento de Chiquimula
INSERT ALL 
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (42, 'Chiquimula', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (43, 'Jocotán', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (44, 'Esquipulas', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (45, 'Camotán', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (46, 'Quezaltepeque', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (47, 'Olopa', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (48, 'Ipala', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (49, 'San Juan Ermita', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (50, 'Concepción Las Minas', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (51, 'San Jacinto', 4)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (52, 'San José la Arada', 4)
SELECT * FROM dual;

-- Municipios del departamento de El Progreso
INSERT ALL 
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (54, 'El Jícaro', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (55, 'Morazán', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (56, 'San Agustín Acasaguastlán', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (57, 'San Antonio La Paz', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (58, 'San Cristóbal Acasaguastlán', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (59, 'Sanarate', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (60, 'Guastatoya', 5)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (61, 'Sansare', 5)
SELECT * FROM dual;


-- Municipios del departamento de Escuintla
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (61, 'Escuintla', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (62, 'Santa Lucía Cotzumalguapa', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (63, 'La Democracia', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (64, 'Siquinalá', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (65, 'Masagua', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (66, 'Tiquisate', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (67, 'La Gomera', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (68, 'Guanagazapa', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (69, 'San José', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (70, 'Iztapa', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (71, 'Palín', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (72, 'San Vicente Pacaya', 6)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (73, 'Nueva Concepción', 6)
SELECT * FROM dual;

-- Municipios del departamento de Guatemala
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (74, 'Santa Catarina Pinula', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (75, 'San José Pinula', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (76, 'Guatemala', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (77, 'San José del Golfo', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (78, 'Palencia', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (79, 'Chinautla', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (80, 'San Pedro Ayampuc', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (81, 'Mixco', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (82, 'San Pedro Sacatepéquez', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (83, 'San Juan Sacatepéquez', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (84, 'Chuarrancho', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (85, 'San Raymundo', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (86, 'Fraijanes', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (87, 'Amatitlán', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (88, 'Villa Nueva', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (89, 'Villa Canales', 7)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (90, 'San Miguel Petapa', 7)
SELECT * FROM dual;



-- Municipios del departamento de Huehuetenango
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (91, 'Huehuetenango', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (92, 'Chiantla', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (93, 'Malacatancito', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (94, 'Cuilco', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (95, 'Nentón', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (96, 'San Pedro Necta', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (97, 'Jacaltenango', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (98, 'Soloma', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (99, 'Ixtahuacán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (100, 'Santa Bárbara', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (101, 'La Libertad', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (102, 'La Democracia', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (103, 'San Miguel Acatán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (104, 'San Rafael La Independencia', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (105, 'Todos Santos Cuchumatán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (106, 'San Juan Atitlán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (107, 'Santa Eulalia', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (108, 'San Mateo Ixtatán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (109, 'Colotenango', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (110, 'San Sebastián Huehuetenango', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (111, 'Tectitán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (112, 'Concepción Huista', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (113, 'San Juan Ixcoy', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (114, 'San Antonio Huista', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (115, 'Santa Cruz Barillas', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (116, 'San Sebastián Coatán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (117, 'Aguacatán', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (118, 'San Rafael Petzal', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (119, 'San Gaspar Ixchil', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (120, 'Santiago Chimaltenango', 8)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (121, 'Santa Ana Huista', 8)
SELECT * FROM dual;

-- Municipios del departamento de Izabal
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (122, 'Morales', 9)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (123, 'Los Amates', 9)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (124, 'Livingston', 9)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (125, 'El Estor', 9)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (126, 'Puerto Barrios', 9)
SELECT * FROM dual;

-- Municipios del departamento de Jalapa
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (127, 'Jalapa', 10)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (128, 'San Pedro Pinula', 10)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (129, 'San Luis Jilotepeque', 10)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (130, 'San Manuel Chaparrón', 10)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (131, 'San Carlos Alzatate', 10)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (132, 'Monjas', 10)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (133, 'Mataquescuintla', 10)
SELECT * FROM dual;

-- Municipios del departamento de Jutiapa
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (134, 'Jutiapa', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (135, 'El Progreso', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (136, 'Santa Catarina Mita', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (137, 'Agua Blanca', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (138, 'Asunción Mita', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (139, 'Yupiltepeque', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (140, 'Atescatempa', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (141, 'Jerez', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (142, 'El Adelanto', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (143, 'Zapotitlán', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (144, 'Comapa', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (145, 'Jalpatagua', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (146, 'Conguaco', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (147, 'Moyuta', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (148, 'Pasaco', 11)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (149, 'Quesada', 11)
SELECT * FROM dual;


-- Municipios del departamento de Petén
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (150, 'Flores', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (151, 'San José', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (152, 'San Benito', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (153, 'San Andrés', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (154, 'La Libertad', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (155, 'San Francisco', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (156, 'Santa Ana', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (157, 'Dolores', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (158, 'San Luis', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (159, 'Sayaxché', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (160, 'Melchor de Mencos', 12)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (161, 'Poptún', 12)
SELECT * FROM dual;

-- Municipios del departamento de Quetzaltenango
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (162, 'Quetzaltenango', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (163, 'Salcajá', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (164, 'San Juan Olintepeque', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (165, 'San Carlos Sija', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (166, 'Sibilia', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (167, 'Cabricán', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (168, 'Cajolá', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (169, 'San Miguel Siguilá', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (170, 'San Juan Ostuncalco', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (171, 'San Mateo', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (172, 'Concepción Chiquirichapa', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (173, 'San Martín Sacatepéquez', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (174, 'Almolonga', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (175, 'Cantel', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (176, 'Huitán', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (177, 'Zunil', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (178, 'Colomba Costa Cuca', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (179, 'San Francisco La Unión', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (180, 'El Palmar', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (181, 'Coatepeque', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (182, 'Génova', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (183, 'Flores Costa Cuca', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (184, 'La Esperanza', 13)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (185, 'Palestina de Los Altos', 13)
SELECT * FROM dual;

-- Municipios del departamento de Quiché
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (186, 'Santa Cruz del Quiché', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (187, 'Chiché', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (188, 'Chinique', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (189, 'Zacualpa', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (190, 'Chajul', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (191, 'Santo Tomás Chichicastenango', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (192, 'Patzité', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (193, 'San Antonio Ilotenango', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (194, 'San Pedro Jocopilas', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (195, 'Cunén', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (196, 'San Juan Cotzal', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (197, 'Santa María Joyabaj', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (198, 'Santa María Nebaj', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (199, 'San Andrés Sajcabajá', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (200, 'Uspantán', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (201, 'Sacapulas', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (202, 'San Bartolomé Jocotenango', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (203, 'Canillá', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (204, 'Chicamán', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (205, 'Ixcán', 14)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (206, 'Pachalum', 14)
SELECT * FROM dual;

-- Municipios del departamento de Retalhuleu
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (207, 'Retalhuleu', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (208, 'San Sebastián', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (209, 'Santa Cruz Muluá', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (210, 'San Martín Zapotitlán', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (211, 'San Felipe', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (212, 'San Andrés Villa Seca', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (213, 'Champerico', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (214, 'Nuevo San Carlos', 15)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (215, 'El Asintal', 15)
SELECT * FROM dual;

-- Municipios del departamento de Sacatepéquez
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (216, 'Antigua Guatemala', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (217, 'Jocotenango', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (218, 'Pastores', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (219, 'Sumpango', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (220, 'Santo Domingo Xenacoj', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (221, 'Santiago Sacatepéquez', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (222, 'San Bartolomé Milpas Altas', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (223, 'San Lucas Sacatepéquez', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (224, 'Santa Lucía Milpas Altas', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (225, 'Magdalena Milpas Altas', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (226, 'Santa María de Jesús', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (227, 'Ciudad Vieja', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (228, 'San Miguel Dueñas', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (229, 'San Juan Alotenango', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (230, 'San Antonio Aguas Calientes', 16)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (231, 'Santa Catarina Barahona', 16)
SELECT * FROM dual;


-- Municipios del departamento de San Marcos
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (232, 'San Marcos', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (233, 'Ayutla', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (234, 'Catarina', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (235, 'Comitancillo', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (236, 'Concepción Tutuapa', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (237, 'El Quetzal', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (238, 'El Rodeo', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (239, 'El Tumblador', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (240, 'Ixchiguán', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (241, 'La Reforma', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (242, 'Malacatán', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (243, 'Nuevo Progreso', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (244, 'Ocós', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (245, 'Pajapita', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (246, 'Esquipulas Palo Gordo', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (247, 'San Antonio Sacatepéquez', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (248, 'San Cristóbal Cucho', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (249, 'San José Ojetenam', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (250, 'San Lorenzo', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (251, 'San Miguel Ixtahuacán', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (252, 'San Pablo', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (253, 'San Pedro Sacatepéquez', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (254, 'San Rafael Pie de la Cuesta', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (255, 'Sibinal', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (256, 'Sipacapa', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (257, 'Tacaná', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (258, 'Tajumulco', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (259, 'Tejutla', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (260, 'Río Blanco', 17)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (261, 'La Blanca', 17)
SELECT * FROM dual;

-- Municipios del departamento de Santa Rosa
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (262, 'Cuilapa', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (263, 'Casillas Santa Rosa', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (264, 'Chiquimulilla', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (265, 'Guazacapán', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (266, 'Nueva Santa Rosa', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (267, 'Oratorio', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (268, 'Pueblo Nuevo Viñas', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (269, 'San Juan Tecuaco', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (270, 'San Rafael Las Flores', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (271, 'Santa Cruz Naranjo', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (272, 'Santa María Ixhuatán', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (273, 'Santa Rosa de Lima', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (274, 'Taxisco', 18)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (275, 'Barberena', 18)
SELECT * FROM dual;

-- Municipios del departamento de Sololá
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (276, 'Sololá', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (277, 'Concepción', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (278, 'Nahualá', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (279, 'Panajachel', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (280, 'San Andrés Semetabaj', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (281, 'San Antonio Palopó', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (282, 'San José Chacayá', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (283, 'San Juan La Laguna', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (284, 'San Lucas Tolimán', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (285, 'San Marcos La Laguna', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (286, 'San Pablo La Laguna', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (287, 'San Pedro La Laguna', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (288, 'Santa Catarina Ixtahuacán', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (289, 'Santa Catarina Palopó', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (290, 'Santa Clara La Laguna', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (291, 'Santa Cruz La Laguna', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (292, 'Santa Lucía Utatlán', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (293, 'Santa María Visitación', 19)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (294, 'Santiago Atitlán', 19)
SELECT * FROM dual;


-- Municipios del departamento de Suchitepéquez
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (295, 'Mazatenango', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (296, 'Cuyotenango', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (297, 'San Francisco Zapotitlán', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (298, 'San Bernardino', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (299, 'San José El Ídolo', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (300, 'Santo Domingo Suchitépequez', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (301, 'San Lorenzo', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (302, 'Samayac', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (303, 'San Pablo Jocopilas', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (304, 'San Antonio Suchitépequez', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (305, 'San Miguel Panán', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (306, 'San Gabriel', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (307, 'Chicacao', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (308, 'Patulul', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (309, 'Santa Bárbara', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (310, 'San Juan Bautista', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (311, 'Santo Tomás La Unión', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (312, 'Zunilito', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (313, 'Pueblo Nuevo', 20)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (314, 'Río Bravo', 20)
SELECT * FROM dual;


-- Municipios del departamento de Totonicapán
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (315, 'Totonicapán', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (316, 'San Cristóbal Totonicapán', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (317, 'San Francisco El Alto', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (318, 'San Andrés Xecul', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (319, 'Momostenango', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (320, 'Santa María Chiquimula', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (321, 'Santa Lucía La Reforma', 21)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (322, 'San Bartolo', 21)
SELECT * FROM dual;


-- Municipios del departamento de Zacapa
INSERT ALL
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (323, 'Cabañas', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (324, 'Estanzuela', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (325, 'Gualán', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (326, 'Huité', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (327, 'La Unión', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (328, 'Río Hondo', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (329, 'San Jorge', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (330, 'San Diego', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (331, 'Teculután', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (332, 'Usumatlán', 22)
INTO Municipio (ID, Nombre_del_Municipio, ID_Departamento) VALUES (333, 'Zacapa', 22)
SELECT * FROM dual;

