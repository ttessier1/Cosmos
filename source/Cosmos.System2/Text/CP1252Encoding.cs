//#define COSMOSDEBUG
using Cosmos.Debug.Kernel;

namespace Cosmos.System.ExtendedASCII
{
    /// <summary>
    /// Represents the CP1252 encoding.
    /// </summary>
    /// <remarks>
    /// See also: <seealso cref="SingleByteEncoding"/>.
    /// </remarks>
    internal class CP1252Enconding : SingleByteEncoding
    {
        /// <summary>
        /// Create new instance of the <see cref="CP1252Enconding"/> class.
        /// </summary>
        internal CP1252Enconding()
        {
            CodePageTable = new char[]
            {
                '€',      '\u0081', '‚',      'ƒ',      '„',      '…',      '†',      '‡',      'ˆ',      '‰',      'Š',      '‹',      'Œ', '\u008E',      'Ž', '\u008F',
                '\u0090', '‘',      '’',      '“',      '”',      '•',      '–',      '—',      '˜',      '™',      'š',      '›',      'œ', '\u009E',      'ž',      'Ÿ',
                '\u00A0', '¡',      '¢',      '£',      '¤',      '¥',      '¦',      '§',      '¨',      '©',      'ª',      '«',      '¬', '\u00AD',      '®',      '¯',
                '°',      '±',      '²',      '³',      '´',      'µ',      '¶',      '·',      '¸',      '¹',      'º',      '»',      '¼',      '½',      '¾',      '¿',
                'À',      'Á',      'Â',      'Ã',      'Ä',      'Å',      'Æ',      'Ç',      'È',      'É',      'Ê',      'Ë',      'Ì',      'Í',      'Î',      'Ï',
                'Ð',      'Ñ',      'Ò',      'Ó',      'Ô',      'Õ',      'Ö',      '×',      'Ø',      'Ù',      'Ú',      'Û',      'Ü',      'Ý',      'Þ',      'ß',
                'à',      'á',      'â',      'ã',      'ä',      'å',      'æ',      'ç',      'è',      'é',      'ê',      'ë',      'ì',      'í',      'î',      'ï',
                'ð',      'ñ',      'ò',      'ó',      'ô',      'õ',      'ö',      '÷',      'ø',      'ù',      'ú',      'û',      'ü',      'ý',      'þ',      'ÿ',
            };
        }

        public override string BodyName => "IBM01252";
        public override int CodePage => 1252;
    }
}
