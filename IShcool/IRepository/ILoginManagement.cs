namespace IShcool.IRepo
{
    public interface ILoginManagement
    {
        /// <summary>
        /// Checking is the student have choosed study plan
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool value true for regestered</returns>
        public Task<bool> IsTeacherSelectedAsync(string id);
    }
}
