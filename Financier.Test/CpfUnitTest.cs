using Xunit;

namespace Financier.Test
{
    public class CpfUniTet
    {
        [Theory(DisplayName = "Confirmar o CPF inválido.")]
        [InlineData("627.030.170-99")]
        [InlineData("9999999999")]
        [InlineData("11111211111")]
        [InlineData("123")]
        public void Confirm_Invalid_Cpf(string cpf)
        {
            var result = Cpf.IsCpf(cpf);
            Assert.False(result);
        }

        [Theory(DisplayName = "Confirmar o CPF válido.")]
        [InlineData("416.810.240-80")]
        [InlineData("084.016.884-50")]
        [InlineData("61679234005")]
        [InlineData("03482638217")]
        public void Confirm_Valid_Cpf(string cpf)
        {
            var result = Cpf.IsCpf(cpf);
            Assert.True(result);
        }
    }
}
