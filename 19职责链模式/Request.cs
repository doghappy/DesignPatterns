namespace _19职责链模式
{
    class Request
    {
        /// <summary>
        /// 申请类别
        /// </summary>
        public RequestType Type { get; set; }

        /// <summary>
        /// 申请内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }
    }
}