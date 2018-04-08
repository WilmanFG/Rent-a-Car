-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-03-2018 a las 04:29:13
-- Versión del servidor: 10.1.25-MariaDB
-- Versión de PHP: 7.0.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `rent_a_car`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `agencias`
--

CREATE TABLE `agencias` (
  `id_agencia` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `direccion` varchar(200) COLLATE utf8_spanish2_ci NOT NULL,
  `telefono` varchar(16) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `agencias`
--

INSERT INTO `agencias` (`id_agencia`, `nombre`, `direccion`, `telefono`) VALUES
(1, 'Toyota', 'La palma, Chalatenango', '2222-2222');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `apellido` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `dui` varchar(9) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `nombre_usuario` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `pasaporte` varchar(11) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `direccion` varchar(200) COLLATE utf8_spanish2_ci NOT NULL,
  `id_pais` int(4) NOT NULL,
  `correo_electronico` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `telefono` varchar(16) COLLATE utf8_spanish2_ci NOT NULL,
  `ciudad` varchar(40) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_cliente`, `nombre`, `apellido`, `dui`, `nombre_usuario`, `pasaporte`, `direccion`, `id_pais`, `correo_electronico`, `telefono`, `ciudad`) VALUES
(1, 'José Moreno', 'Hernandez Nono', '12345678-', 'CL37466', '1', 'Barrio La Vega, casa #1', 1, 'lopezleonardo282@gmail.com', '7777-8888', 'Tonacatepeque'),
(2, 'Jose', 'Hola', '12345678-', 'CL52418', '1', 'SANTA TECLA', 1, 'lopezleonardo282@gmail.com', '7777-8888', 'sss');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `coches`
--

CREATE TABLE `coches` (
  `id_coche` int(11) NOT NULL,
  `placa` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `marca` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `modelo` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `color` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `kilometraje` smallint(6) NOT NULL,
  `num_pasajeros` tinyint(4) NOT NULL,
  `precio_alquiler` decimal(10,0) NOT NULL,
  `fotografia` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `tipo` varchar(15) COLLATE utf8_spanish2_ci NOT NULL,
  `estado` char(1) COLLATE utf8_spanish2_ci NOT NULL COMMENT '"A": Activo, "R": en reparación',
  `id_agencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `coches`
--

INSERT INTO `coches` (`id_coche`, `placa`, `marca`, `modelo`, `color`, `kilometraje`, `num_pasajeros`, `precio_alquiler`, `fotografia`, `tipo`, `estado`, `id_agencia`) VALUES
(1, '2', 'Ford', 'Focus', 'Azul', 1, 5, '10', 'AF.jpg', 'Sedan', 'A', 1),
(5, 'P456 123', 'Toyota', 'Corolla', 'Azul Marino', 0, 5, '50', '5.png', 'Sedan', 'A', 1),
(7, 'P548975', 'Scion', 'T', 'Azul', 2, 4, '30', '7.jpg', 'Sedan', 'A', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `multas`
--

CREATE TABLE `multas` (
  `id_multa` int(11) NOT NULL,
  `id_renta` char(15) COLLATE utf8_spanish2_ci NOT NULL,
  `descripcion` varchar(255) COLLATE utf8_spanish2_ci NOT NULL,
  `monto` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paises`
--

CREATE TABLE `paises` (
  `id_pais` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `paises`
--

INSERT INTO `paises` (`id_pais`, `nombre`) VALUES
(1, 'El Salvador'),
(2, 'Costa Rica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rentas`
--

CREATE TABLE `rentas` (
  `id_renta` char(15) COLLATE utf8_spanish2_ci NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_agencia` int(11) NOT NULL,
  `id_coche` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha_retiro` date NOT NULL,
  `fecha_devolucion` date NOT NULL,
  `estado` varchar(15) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'Puede contener: "Activa", "Devuelto"'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservas`
--

CREATE TABLE `reservas` (
  `id_reserva` varchar(15) COLLATE utf8_spanish2_ci NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_agencia` int(11) NOT NULL,
  `id_coche` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha_retiro` date NOT NULL,
  `fecha_devolucion` date NOT NULL,
  `estado` varchar(15) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'Puede contener: "Activa", "Realizada", "Cancelada"'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `reservas`
--

INSERT INTO `reservas` (`id_reserva`, `id_cliente`, `id_agencia`, `id_coche`, `id_usuario`, `fecha_retiro`, `fecha_devolucion`, `estado`) VALUES
('20171000001', 1, 1, 1, 8, '2017-10-14', '2017-10-10', 'Cancelada'),
('20171000002', 1, 1, 1, 8, '2017-10-10', '2017-10-14', 'Cancelada'),
('20171000003', 1, 1, 1, 8, '2017-10-10', '2017-10-14', 'Cancelada'),
('20171000004', 1, 1, 1, 8, '2017-10-10', '2017-10-14', 'Cancelada'),
('20171000005', 1, 1, 1, 8, '2017-10-10', '2017-10-14', 'Cancelada'),
('20171000006', 1, 1, 1, 8, '2017-10-10', '2017-10-14', 'Cancelada'),
('20171000007', 1, 1, 1, 8, '2017-10-10', '2017-10-14', 'Activa');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `apellido` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `nombre_usuario` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `contraseña` varchar(900) COLLATE utf8_spanish2_ci NOT NULL,
  `perfil` varchar(20) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'Puede contener: "Administrador", "Agente" o "Contador"'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nombre`, `apellido`, `nombre_usuario`, `contraseña`, `perfil`) VALUES
(8, 'Leonardo', 'López', 'A50882', '10473!111153?108113*9702!73352*110133*10363!108113-10583/115193/10473-53L2?', 'Administrador'),
(9, 'Franklin', 'Esquivel', 'A41272', '10473!111153?108113*9702!73352*110133*10363!108113-10583/115193/10473-53L2?', 'Administrador'),
(10, 'Diego', 'Lemus', 'C24125', '10473!111153?108113*9702!73352*110133*10363!108113-10583/115193/10473-53L2?', 'Contador'),
(11, 'Rodrigo', 'Lemus', 'C26644', '10473!111153?108113*9702!73352*110133*10363!108113-10583/115193/10473-53L2?', 'Contador'),
(12, 'José', 'Bardales', 'G40568', '10473!111153?108113*9702!73352*110133*10363!108113-10583/115193/10473-53L2?', 'Gerente');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `agencias`
--
ALTER TABLE `agencias`
  ADD PRIMARY KEY (`id_agencia`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `id_pais` (`id_pais`);

--
-- Indices de la tabla `coches`
--
ALTER TABLE `coches`
  ADD PRIMARY KEY (`id_coche`),
  ADD UNIQUE KEY `placa` (`placa`),
  ADD KEY `id_agencia` (`id_agencia`),
  ADD KEY `id_agencia_2` (`id_agencia`),
  ADD KEY `id_agencia_3` (`id_agencia`),
  ADD KEY `id_agencia_4` (`id_agencia`);

--
-- Indices de la tabla `multas`
--
ALTER TABLE `multas`
  ADD PRIMARY KEY (`id_multa`),
  ADD KEY `id_renta` (`id_renta`),
  ADD KEY `id_renta_2` (`id_renta`);

--
-- Indices de la tabla `paises`
--
ALTER TABLE `paises`
  ADD PRIMARY KEY (`id_pais`);

--
-- Indices de la tabla `rentas`
--
ALTER TABLE `rentas`
  ADD PRIMARY KEY (`id_renta`),
  ADD KEY `id_cliente` (`id_cliente`,`id_agencia`,`id_coche`,`id_usuario`),
  ADD KEY `id_cliente_2` (`id_cliente`,`id_agencia`,`id_coche`,`id_usuario`),
  ADD KEY `id_agencia` (`id_agencia`,`id_coche`,`id_usuario`),
  ADD KEY `id_coche` (`id_coche`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `reservas`
--
ALTER TABLE `reservas`
  ADD PRIMARY KEY (`id_reserva`),
  ADD KEY `id_cliente` (`id_cliente`,`id_agencia`,`id_coche`,`id_usuario`),
  ADD KEY `id_cliente_2` (`id_cliente`),
  ADD KEY `id_agencia` (`id_agencia`),
  ADD KEY `id_coche` (`id_coche`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `agencias`
--
ALTER TABLE `agencias`
  MODIFY `id_agencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `coches`
--
ALTER TABLE `coches`
  MODIFY `id_coche` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `multas`
--
ALTER TABLE `multas`
  MODIFY `id_multa` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `paises`
--
ALTER TABLE `paises`
  MODIFY `id_pais` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`id_pais`) REFERENCES `paises` (`id_pais`);

--
-- Filtros para la tabla `coches`
--
ALTER TABLE `coches`
  ADD CONSTRAINT `coches_ibfk_1` FOREIGN KEY (`id_agencia`) REFERENCES `agencias` (`id_agencia`);

--
-- Filtros para la tabla `multas`
--
ALTER TABLE `multas`
  ADD CONSTRAINT `multas_ibfk_1` FOREIGN KEY (`id_renta`) REFERENCES `rentas` (`id_renta`);

--
-- Filtros para la tabla `rentas`
--
ALTER TABLE `rentas`
  ADD CONSTRAINT `rentas_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`),
  ADD CONSTRAINT `rentas_ibfk_2` FOREIGN KEY (`id_agencia`) REFERENCES `agencias` (`id_agencia`),
  ADD CONSTRAINT `rentas_ibfk_3` FOREIGN KEY (`id_coche`) REFERENCES `coches` (`id_coche`),
  ADD CONSTRAINT `rentas_ibfk_4` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);

--
-- Filtros para la tabla `reservas`
--
ALTER TABLE `reservas`
  ADD CONSTRAINT `reservas_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`),
  ADD CONSTRAINT `reservas_ibfk_2` FOREIGN KEY (`id_agencia`) REFERENCES `agencias` (`id_agencia`),
  ADD CONSTRAINT `reservas_ibfk_3` FOREIGN KEY (`id_coche`) REFERENCES `coches` (`id_coche`),
  ADD CONSTRAINT `reservas_ibfk_4` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
