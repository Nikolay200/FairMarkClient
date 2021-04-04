﻿namespace FairMark.SuzApi.Dictionaries
{
    /// <summary>
    /// Возможные значения справочника «Способ выпуска товаров в оборот»
    /// </summary>
    public enum ReleaseMethodTypes
    {
        /// <summary>
        /// Производство в РФ
        /// </summary>
        PRODUCTION,

        /// <summary>
        /// Ввезен в РФ (Импорт)
        /// </summary>
        IMPORT,

        /// <summary>
        /// Маркировка остатков (доступно только для ТГ «Альтернативная табачная продукция», «Духи и туалетная вода», «Предметы одежды, белье постельное, столовое, туалетное и кухонное»)
        /// </summary>
        REMAINS,

        /// <summary>
        /// Доступен исключительно Операторам ЕАЭС для следующих товарных групп («Обувные товары», «Предметы одежды, белье постельное, столовое, туалетное и кухонное», «Шины и покрышки пневматические резиновые новые», «Духи и туалетная вода», «Фотокамеры (кроме кинокамер), фотовспышки и лампы-вспышки») в том числе «Молочная продукция»
        /// </summary>
        CROSSBORDER,

        /// <summary>
        /// Перемаркировка (доступно только для ТГ «Предметы одежды, белье постельное, столовое, туалетное и кухонное», «Обувные товары», «Шины и покрышки пневматические резиновые новые», «Духи и туалетная вода», «Фотокамеры (кроме кинокамер), фотовспышки и лампывспышки», «Велосипеды и велосипедные рамы», «Кресла-коляски»).
        /// </summary>
        REMARK,

        /// <summary>
        /// Принят на комиссию от физического лица (доступно для для ТГ «Предметы одежды, белье постельное, столовое, туалетное и кухонное», «Обувные товары»)
        /// </summary>
        COMMISSION
    }
}