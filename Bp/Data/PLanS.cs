namespace Bp.Data
{
    public class PLanS
    {
        private enum EvenTypes
        {
            premium = 3,
            ideal = 1,
            pluss = 2,
            
        };

        private struct EventPlann
        {
            public int Id;
            public string Name;
            //EvenTypes eventTypes;
            //DateTime DateTime;
        }

        // put an accessable list here

        public Task<BoxPopuli[]> GetBoxPopulisSync(DateTime startDate)
        {
            startDate.AddDays(1);
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new BoxPopuli
            {
                
                //
            }).ToArray());
        }

      
    }
}
