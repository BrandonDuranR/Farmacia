-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-04-2023 a las 10:29:47
-- Versión del servidor: 10.4.27-MariaDB
-- Versión de PHP: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `farmacia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacen`
--

CREATE TABLE `almacen` (
  `ID_PRODUCTO` int(11) DEFAULT NULL,
  `stock` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `almacen`
--

INSERT INTO `almacen` (`ID_PRODUCTO`, `stock`) VALUES
(2, '1220');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `laboratorio`
--

CREATE TABLE `laboratorio` (
  `IDLABORATORIO` int(11) NOT NULL,
  `NOMBRE` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `laboratorio`
--

INSERT INTO `laboratorio` (`IDLABORATORIO`, `NOMBRE`) VALUES
(1, 'Merck'),
(2, 'Boehringer Ingelheim'),
(3, 'Schering Plough'),
(4, 'Bayer'),
(5, 'Astrazeneca'),
(6, 'Pfizer'),
(7, 'Glaxosmithkline'),
(8, 'Baxter'),
(9, 'Eli Lilly Company'),
(10, 'Novartis');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lote`
--

CREATE TABLE `lote` (
  `ID_LOTE` int(11) NOT NULL,
  `ID_PRODUCTO` int(11) DEFAULT NULL,
  `PIEZAS` varchar(255) DEFAULT NULL,
  `CADUCIDAD` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `lote`
--

INSERT INTO `lote` (`ID_LOTE`, `ID_PRODUCTO`, `PIEZAS`, `CADUCIDAD`) VALUES
(1, 1, '100', '2023-04-12'),
(2, 2, '-404', '2023-04-12'),
(3, 2, '-180', '2023-04-10'),
(4, 2, '-90', '2023-04-11'),
(5, 2, '800', '2023-04-09');

--
-- Disparadores `lote`
--
DELIMITER $$
CREATE TRIGGER `ALTA_PRODUCTO` AFTER INSERT ON `lote` FOR EACH ROW UPDATE almacen SET almacen.stock = almacen.stock + NEW.PIEZAS WHERE almacen.ID_PRODUCTO=NEW.ID_PRODUCTO
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `ID_PRODUCTO` int(11) NOT NULL,
  `ID_PROVEEDOR` int(11) DEFAULT NULL,
  `NOMBRE` varchar(255) DEFAULT NULL,
  `CODIGOBARRAS` varchar(11) DEFAULT NULL,
  `PRECIO` decimal(10,2) DEFAULT NULL,
  `UNIDADMEDIDA` varchar(255) DEFAULT NULL,
  `CANTIDADMEDIDA` varchar(255) DEFAULT NULL,
  `OBSERVACIONES` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`ID_PRODUCTO`, `ID_PROVEEDOR`, `NOMBRE`, `CODIGOBARRAS`, `PRECIO`, `UNIDADMEDIDA`, `CANTIDADMEDIDA`, `OBSERVACIONES`) VALUES
(1, 4, 'test', '12345678911', '100.20', 'test', 'test', 'test'),
(2, 8, 'TESTT', '1', '1.00', 'TEST', 'TEW', 'TEST');

--
-- Disparadores `productos`
--
DELIMITER $$
CREATE TRIGGER `ALTA_ALMACEN` AFTER INSERT ON `productos` FOR EACH ROW INSERT almacen SET almacen.ID_PRODUCTO = NEW.ID_PRODUCTO, almacen.stock=0
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productosvendidos`
--

CREATE TABLE `productosvendidos` (
  `ID_PRODUCTOSVENDIDOS` int(11) NOT NULL,
  `ID_VENTA` int(11) DEFAULT NULL,
  `ID_PRODUCTO` int(11) DEFAULT NULL,
  `CANTIDAD` int(11) DEFAULT NULL,
  `FECHA_VENTA` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productosvendidos`
--

INSERT INTO `productosvendidos` (`ID_PRODUCTOSVENDIDOS`, `ID_VENTA`, `ID_PRODUCTO`, `CANTIDAD`, `FECHA_VENTA`) VALUES
(9, 1, 2, 10, '2023-04-09'),
(10, 1, 2, 10, '2023-04-09'),
(11, NULL, 2, 10, '2023-04-09'),
(12, 1, 2, NULL, '2023-04-09'),
(13, 1, 2, NULL, '2023-04-09'),
(14, 1, 2, NULL, '2023-04-08'),
(15, 1, 2, NULL, '2023-04-08'),
(16, 1, 2, NULL, '2023-04-09'),
(17, 1, 2, 200, '2023-04-08'),
(18, NULL, 2, 200, '2023-04-08'),
(19, 1, 2, 4, '2023-04-08'),
(20, 1, 2, 100, '2023-04-09');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `IDUSER` int(11) NOT NULL,
  `NOMBRE` varchar(255) NOT NULL,
  `APELLIDO_P` varchar(255) NOT NULL,
  `APELLIDO_M` varchar(255) NOT NULL,
  `TELEFONO` varchar(10) NOT NULL,
  `EMAIL` varchar(255) NOT NULL,
  `CP` int(5) NOT NULL,
  `DIRECCION` text NOT NULL,
  `USUARIO` varchar(255) NOT NULL,
  `CONTRASENA` varchar(255) NOT NULL,
  `ROL` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`IDUSER`, `NOMBRE`, `APELLIDO_P`, `APELLIDO_M`, `TELEFONO`, `EMAIL`, `CP`, `DIRECCION`, `USUARIO`, `CONTRASENA`, `ROL`) VALUES
(1, 'Brandon', 'Duran', 'Rocha', '5577441122', 'brandon_duran@gmail.com', 55630, 'Calle Benito Juarez 33b, Cuautepec barrio bajo, CDMX', 'Brandon', 'Duran', 'ADMIN'),
(2, 'Marco Antonio', 'Sanchez', 'Fermin', '5532124565', 'marcosanchez@gmail.com', 43803, 'Nacozari, 43803 Tizayuca, Hgo', 'Marco', 'Sanchez', 'VENTAS'),
(3, 'Fabrice', 'Salazar', 'Campos', '5587365425', 'fabriceakagata@gmail.com', 55605, 'Del Paraíso, Zumpango, 55600 Zumpango de Ocampo, Méx.', 'fabrice', 'salazar', 'ALMACEN'),
(4, 'adas', 'asdasdasdasdasd', 'adasd', '1111231321', 'asdasd', 54151, 'asdasd', 'as', 'as', 'ADMIN'),
(5, 'adas', 'asdasdasdasdasd', 'adasd', '1111231321', 'asdasd', 54151, 'asdasd', 'as', 'as', 'ADMIN');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `ID_VENTA` int(11) NOT NULL,
  `FECHA` date DEFAULT NULL,
  `TOTAL` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`ID_VENTA`, `FECHA`, `TOTAL`) VALUES
(1, '2023-04-10', '1200.00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `almacen`
--
ALTER TABLE `almacen`
  ADD KEY `ID_PRODUCTO` (`ID_PRODUCTO`);

--
-- Indices de la tabla `laboratorio`
--
ALTER TABLE `laboratorio`
  ADD PRIMARY KEY (`IDLABORATORIO`);

--
-- Indices de la tabla `lote`
--
ALTER TABLE `lote`
  ADD PRIMARY KEY (`ID_LOTE`),
  ADD KEY `ID_PRODUCTO` (`ID_PRODUCTO`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`ID_PRODUCTO`),
  ADD KEY `ID_PROVEEDOR` (`ID_PROVEEDOR`);

--
-- Indices de la tabla `productosvendidos`
--
ALTER TABLE `productosvendidos`
  ADD PRIMARY KEY (`ID_PRODUCTOSVENDIDOS`),
  ADD KEY `ID_VENTA` (`ID_VENTA`),
  ADD KEY `ID_PRODUCTO` (`ID_PRODUCTO`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IDUSER`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`ID_VENTA`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `laboratorio`
--
ALTER TABLE `laboratorio`
  MODIFY `IDLABORATORIO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `lote`
--
ALTER TABLE `lote`
  MODIFY `ID_LOTE` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `ID_PRODUCTO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `productosvendidos`
--
ALTER TABLE `productosvendidos`
  MODIFY `ID_PRODUCTOSVENDIDOS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IDUSER` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `ID_VENTA` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `almacen`
--
ALTER TABLE `almacen`
  ADD CONSTRAINT `almacen_ibfk_1` FOREIGN KEY (`ID_PRODUCTO`) REFERENCES `productos` (`ID_PRODUCTO`) ON DELETE CASCADE;

--
-- Filtros para la tabla `lote`
--
ALTER TABLE `lote`
  ADD CONSTRAINT `lote_ibfk_1` FOREIGN KEY (`ID_PRODUCTO`) REFERENCES `productos` (`ID_PRODUCTO`) ON DELETE CASCADE;

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`ID_PROVEEDOR`) REFERENCES `laboratorio` (`IDLABORATORIO`) ON DELETE CASCADE;

--
-- Filtros para la tabla `productosvendidos`
--
ALTER TABLE `productosvendidos`
  ADD CONSTRAINT `productosvendidos_ibfk_1` FOREIGN KEY (`ID_VENTA`) REFERENCES `ventas` (`ID_VENTA`) ON DELETE CASCADE,
  ADD CONSTRAINT `productosvendidos_ibfk_2` FOREIGN KEY (`ID_PRODUCTO`) REFERENCES `productos` (`ID_PRODUCTO`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
