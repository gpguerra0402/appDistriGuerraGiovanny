﻿namespace cpn_ctasMasivasSubscribe_service.MQ
{
    public class RabbitMQSettings
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? VirtualHost { get; set; }
        public int Port { get; set; }
        public string? Hostname { get; set; }
    }
}
