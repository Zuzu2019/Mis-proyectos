-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-10-2023 a las 07:23:59
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `servicio`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacion`
--

CREATE TABLE `clasificacion` (
  `id` int(11) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `publico` varchar(200) NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clasificacion`
--

INSERT INTO `clasificacion` (`id`, `clave`, `publico`, `eliminado`) VALUES
(1, 'AA', 'Películas para todo público que tengan además atractivo infantil y sean comprensibles para niños menores de siete años de edad.', 0),
(2, 'A', 'Películas para todo público.', 0),
(3, 'B', 'Películas para adolescentes de 12 años en adelante.', 0),
(4, 'B15', 'Película no recomendable para menores de 15 años de edad.', 0),
(5, 'C', 'Películas para adultos de 18 años en adelante.', 0),
(6, 'D', 'Películas para adultos, con sexo explícito, lenguaje procaz o alto grado de violencia.', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE `cuenta` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellido1` varchar(50) DEFAULT NULL,
  `apellidos` varchar(150) NOT NULL,
  `correo` varchar(45) NOT NULL,
  `tipo` varchar(45) NOT NULL,
  `pais` varchar(45) NOT NULL,
  `numtarjeta` int(10) UNSIGNED NOT NULL,
  `periodicidad` varchar(45) NOT NULL,
  `fechacreacion` datetime NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0,
  `apellido2` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cuenta`
--

INSERT INTO `cuenta` (`id`, `nombre`, `apellido1`, `apellidos`, `correo`, `tipo`, `pais`, `numtarjeta`, `periodicidad`, `fechacreacion`, `eliminado`, `apellido2`) VALUES
(1, 'Admin', 'apellido1', 'istrador', 'admin1@correo.com', 'free', 'a', 111111, 'anual', '2022-05-09 17:02:36', 0, 'apellido2'),
(2, 'Cristian', 'Hernandez', '', 'cristian@gmail.com', 'premium', 'EU', 1526373839, 'mensual', '2023-05-28 21:05:00', 0, 'Soto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genero`
--

CREATE TABLE `genero` (
  `id` int(11) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `genero`
--

INSERT INTO `genero` (`id`, `clave`, `nombre`, `eliminado`) VALUES
(1, '1', 'comedia', 0),
(2, '2', 'terror', 0),
(3, '3', 'drama', 0),
(4, '4', 'accion', 0),
(5, '5', 'aventura', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pelicula`
--

CREATE TABLE `pelicula` (
  `id` int(11) NOT NULL,
  `titulo` varchar(45) NOT NULL,
  `duracion` varchar(45) NOT NULL,
  `rutaportada` varchar(45) NOT NULL,
  `idregion` int(11) NOT NULL,
  `idgenero` int(11) NOT NULL,
  `idclasificacion` int(11) NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pelicula`
--

INSERT INTO `pelicula` (`id`, `titulo`, `duracion`, `rutaportada`, `idregion`, `idgenero`, `idclasificacion`, `eliminado`) VALUES
(1, 'El rey leon', '1h58m', 'peliculas/reyleon.jpg', 1, 5, 6, 0),
(2, 'Mi villano favorito', '1h36m', 'peliculas/villanofavorito.jpg', 3, 2, 3, 0),
(3, 'Avengers', '3h', 'peliculas/avengers.jpg', 5, 2, 3, 0),
(4, 'La bella y la bestia', '1h44m', 'peliculas/bella.jpg', 7, 1, 1, 0),
(5, 'Alicia en el pais de las maravillas', '3h2m', 'peliculas/alicia.jpg', 2, 3, 2, 0),
(12, 'Toy Story', '3h4m', 'peliculas/toy.jpg', 4, 4, 2, 1),
(13, 'Los increibles 2', '3h4m', 'peliculas/increibles.jpg', 4, 4, 2, 1),
(14, 'Jurassic World', '3h23m', 'peliculas/juri.jpg', 4, 2, 4, 0),
(15, 'Spider Man: sin camino  a casa', '3h23m', 'peliculas/spiderman.jpg', 4, 2, 4, 1),
(16, 'Buscando a Dori', '3h55m', 'peliculas/dory.jpg', 7, 4, 3, 0),
(17, 'Star Wars: El despertar de la fuerza', '1h33m', 'peliculas/star.jpg', 2, 1, 2, 0),
(18, 'Los juegos de hambre: en llamas', '2h88m', 'peliculas/hambre.jpg', 5, 2, 6, 0),
(19, 'Operacion SKIFALL', '2h8m', 'peliculas/ski.jpg', 6, 3, 4, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `id` int(11) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `idioma` varchar(45) NOT NULL,
  `edad` int(11) NOT NULL,
  `rutaimagen` varchar(45) NOT NULL,
  `idcuenta` int(11) NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`id`, `usuario`, `idioma`, `edad`, `rutaimagen`, `idcuenta`, `eliminado`) VALUES
(1, 'admin', 'hebreo', 99, 'femenino.png', 1, 0),
(8, 'cristian2', 'ingles', 19, 'masculino.jpg', 1, 0),
(9, 'Cristian v3', 'aleman', 20, 'masculino.jpg', 1, 0),
(10, 'Cristian v4', 'ruso', 28, 'masculino.jpg', 1, 0),
(11, 'cris', 'español', 20, 'femenino.jpg', 2, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `region`
--

CREATE TABLE `region` (
  `id` int(11) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `eliminado` tinyint(2) UNSIGNED NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `region`
--

INSERT INTO `region` (`id`, `clave`, `descripcion`, `eliminado`) VALUES
(1, '0', 'Todas', 0),
(2, '1', 'Canada, USA, EUA', 0),
(3, '2', 'Japon, Europa, Sudafrica, el Oriente Medio incluyendo Egipto y Groenlandia.', 0),
(4, '3', 'Sudeste de Asia y Este de Asia, Hong Kong.', 0),
(5, '4', 'Australia, Nueva Zelanda, las Islas del Pacífico, America Central, México, Sudamérica y el Caribe.', 0),
(6, '5', 'Europa del Este, Rusia, el subcontinente Indio, africa, Corea del Norte y Mongolia', 0),
(7, '6', 'China.', 0),
(8, '7', 'Reservado para uso especial no especificado.', 0),
(9, '8', 'Medios internacionales especiales para el transporte aéreo y oceanico.', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `serie`
--

CREATE TABLE `serie` (
  `id` int(11) NOT NULL,
  `titulo` varchar(45) NOT NULL,
  `numtemporadas` int(11) NOT NULL,
  `totalcapitulos` int(11) NOT NULL,
  `rutaportada` varchar(45) NOT NULL,
  `idregion` int(11) NOT NULL,
  `idgenero` int(11) NOT NULL,
  `idclasificacion` int(11) NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `serie`
--

INSERT INTO `serie` (`id`, `titulo`, `numtemporadas`, `totalcapitulos`, `rutaportada`, `idregion`, `idgenero`, `idclasificacion`, `eliminado`) VALUES
(1, 'Asi nos ven', 5, 635, 'series/asinosven.jpeg', 7, 5, 6, 0),
(2, 'Peaky Blinders', 4, 5, 'series/peaky.jpg', 1, 3, 4, 0),
(3, 'Black Mirror', 2, 20, 'series/black.jpg', 7, 4, 6, 0),
(4, 'Narcos', 5, 3, 'series/narcos.jpeg', 4, 1, 3, 0),
(5, 'BoJack Horseman', 1, 20, 'series/horse.jpg', 6, 2, 1, 0),
(6, 'Stranger Things', 3, 16, 'series/stranger.jpg', 4, 3, 2, 1),
(7, 'The Crown', 1, 40, 'series/crown.jpg', 4, 3, 2, 1),
(8, 'Dark', 7, 54, 'series/dark.jpg', 3, 3, 5, 1),
(9, 'Daredevil', 3, 54, 'series/darevil.jpg', 3, 3, 5, 1),
(10, 'Mindhunter', 1, 4, 'series/mindhunter.jpg', 4, 3, 2, 1),
(11, 'Gambito de dama', 2, 4, 'series/gambito.jpeg', 4, 3, 2, 1),
(12, 'The Last Kingdom', 4, 31, 'series/kingdom.jpeg', 5, 5, 3, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `user` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `nivel` tinyint(2) NOT NULL,
  `idcuenta` int(11) NOT NULL,
  `eliminado` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `user`, `pass`, `nivel`, `idcuenta`, `eliminado`) VALUES
(1, 'admin', '12345', 0, 1, 0),
(2, 'cristian', 'cristian', 0, 2, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `genero`
--
ALTER TABLE `genero`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pelicula`
--
ALTER TABLE `pelicula`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fkg` (`idgenero`),
  ADD KEY `fkc` (`idclasificacion`),
  ADD KEY `fkr` (`idregion`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`idcuenta`);

--
-- Indices de la tabla `region`
--
ALTER TABLE `region`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `serie`
--
ALTER TABLE `serie`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idr` (`idregion`),
  ADD KEY `idg` (`idgenero`),
  ADD KEY `idc` (`idclasificacion`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idcuenta` (`idcuenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `genero`
--
ALTER TABLE `genero`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `pelicula`
--
ALTER TABLE `pelicula`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `region`
--
ALTER TABLE `region`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `serie`
--
ALTER TABLE `serie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
