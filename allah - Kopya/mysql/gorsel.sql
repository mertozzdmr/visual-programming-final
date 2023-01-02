-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 22:04:03
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `gorsel`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `aletler`
--

CREATE TABLE `aletler` (
  `id` int(11) NOT NULL,
  `isim` varchar(50) NOT NULL,
  `yapı` varchar(100) NOT NULL,
  `isim1` text NOT NULL,
  `yapı1` text NOT NULL,
  `isim2` text NOT NULL,
  `yapı2` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `aletler`
--

INSERT INTO `aletler` (`id`, `isim`, `yapı`, `isim1`, `yapı1`, `isim2`, `yapı2`) VALUES
(4, '', '', '', '', '', ''),
(5, 'piyano', '8 oktavdan olusur', 'gitar', '6 telden olusur', 'saz', '6 telden olusur');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hakkimizda`
--

CREATE TABLE `hakkimizda` (
  `id` int(11) NOT NULL,
  `hakkimizda` varchar(160) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `hakkimizda`
--

INSERT INTO `hakkimizda` (`id`, `hakkimizda`) VALUES
(1, 'Muzik uygulamamızı 2009 senesinde mert özdemirle beraber yapımına başlanmıştır. \r\nBu programın yapımında sayın Murat Sarı hocamızın çok emeği geçmiştir tek dile');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `kadi` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `isim` varchar(255) NOT NULL,
  `soyisim` varchar(255) NOT NULL,
  `telefon` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `login`
--

INSERT INTO `login` (`id`, `kadi`, `sifre`, `isim`, `soyisim`, `telefon`) VALUES
(3, 'merdo', '1234', 'mert', 'özdemir', '1234'),
(4, 'recep', '1234', 'Recep', 'İvedik', '1234'),
(5, 'musti', '1234', 'mustafa', 'keller', '1234');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_sozler`
--

CREATE TABLE `tbl_sozler` (
  `ID` int(11) NOT NULL,
  `sozler` varchar(255) NOT NULL,
  `aciklama` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `tbl_sozler`
--

INSERT INTO `tbl_sozler` (`ID`, `sozler`, `aciklama`) VALUES
(1, 'Duman-Melankoli', 'Özledim seni harbiden\r\nAklıma da düşüverir aniden\r\nİçince, açılınca\r\nBekledin, sana gelmedim\r\nGeceleri gönlüme eğledim\r\nUçunca, uyuşunca'),
(2, 'Duman-Melek', 'Kendisi bir garip melek\r\nArdına düşmeniz gerek\r\nKendisi bir garip melek\r\nArdına düşmeniz gerek\r\nÖyle bir an gelir melek\r\nFarkına varmanız gerek\r\nÖyle bir an gider melek\r\nFarkına varmanız gerek');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `aletler`
--
ALTER TABLE `aletler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `hakkimizda`
--
ALTER TABLE `hakkimizda`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_sozler`
--
ALTER TABLE `tbl_sozler`
  ADD PRIMARY KEY (`ID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `aletler`
--
ALTER TABLE `aletler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `hakkimizda`
--
ALTER TABLE `hakkimizda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_sozler`
--
ALTER TABLE `tbl_sozler`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
