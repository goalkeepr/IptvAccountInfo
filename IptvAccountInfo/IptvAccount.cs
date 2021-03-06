﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//using QuickType;
//
//    var iptvAccount = IptvAccount.FromJson(jsonString);

namespace IptvAccountInfo
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class IptvAccount
    {
        [JsonProperty("user_info", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("server_info", NullValueHandling = NullValueHandling.Ignore)]
        public ServerInfo ServerInfo { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public Categories Categories { get; set; }

        [JsonProperty("available_channels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, AvailableChannel> AvailableChannels { get; set; }
    }

    public partial class AvailableChannel
    {
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public long? Num { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("stream_type", NullValueHandling = NullValueHandling.Ignore)]
        public StreamType? StreamType { get; set; }

        [JsonProperty("type_name", NullValueHandling = NullValueHandling.Ignore)]
        public TypeName? TypeName { get; set; }

        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? StreamId { get; set; }

        [JsonProperty("stream_icon", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamIcon { get; set; }

        [JsonProperty("epg_channel_id")]
        public string EpgChannelId { get; set; }

        [JsonProperty("added", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Added { get; set; }

        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryName? CategoryName { get; set; }

        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CategoryId { get; set; }

        [JsonProperty("series_no")]
        public object SeriesNo { get; set; }

        [JsonProperty("live", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Live { get; set; }

        [JsonProperty("container_extension")]
        public object ContainerExtension { get; set; }

        [JsonProperty("custom_sid", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomSid { get; set; }

        [JsonProperty("tv_archive", NullValueHandling = NullValueHandling.Ignore)]
        public long? TvArchive { get; set; }

        [JsonProperty("direct_source", NullValueHandling = NullValueHandling.Ignore)]
        public string DirectSource { get; set; }

        [JsonProperty("tv_archive_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? TvArchiveDuration { get; set; }
    }

    public partial class Categories
    {
        [JsonProperty("movie", NullValueHandling = NullValueHandling.Ignore)]
        public Live[] Movie { get; set; }

        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public Live[] Series { get; set; }

        [JsonProperty("live", NullValueHandling = NullValueHandling.Ignore)]
        public Live[] Live { get; set; }
    }

    public partial class Live
    {
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CategoryId { get; set; }

        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentId { get; set; }
    }

    public partial class ServerInfo
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Port { get; set; }

        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? HttpsPort { get; set; }

        [JsonProperty("server_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerProtocol { get; set; }
    }

    public partial class UserInfo
    {
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Auth { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("exp_date", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ExpDate { get; set; }

        [JsonProperty("is_trial", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? IsTrial { get; set; }

        [JsonProperty("active_cons", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ActiveCons { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CreatedAt { get; set; }

        [JsonProperty("max_connections", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MaxConnections { get; set; }

        [JsonProperty("allowed_output_formats", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AllowedOutputFormats { get; set; }
    }

    public enum CategoryName { Other, CanadianChannels, EspnSports, InternationalSports, LocalChannels, MlbChannels, MusicChoiceVideo, NhlPlayoffs, PpvSpecialEvents, The247, The247Kids, UkChannels, Usa2Channels, UsaChannels, UsaSdChannels, UsaSports, XxxChannelsXxx };

    public enum ContainerExtension { Avi, Mkv, Mp4, Mpg };

    public enum StreamType { CreatedLive, Live, Movie, RadioStreams };

    public enum TypeName { CreatedLiveChannels, LiveStreams, Movies, Radio };

    public partial class IptvAccount
    {
        public static IptvAccount FromJson(string json) => JsonConvert.DeserializeObject<IptvAccount>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this IptvAccount self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CategoryNameConverter.Singleton,
                StreamTypeConverter.Singleton,
                TypeNameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class CategoryNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CategoryName) || t == typeof(CategoryName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "24/7":
                    return CategoryName.The247;
                case "24/7 KIDS":
                    return CategoryName.The247Kids;
                case "CANADIAN CHANNELS":
                    return CategoryName.CanadianChannels;
                case "ESPN SPORTS":
                    return CategoryName.EspnSports;
                case "INTERNATIONAL SPORTS":
                    return CategoryName.InternationalSports;
                case "LOCAL CHANNELS":
                    return CategoryName.LocalChannels;
                case "MLB CHANNELS":
                    return CategoryName.MlbChannels;
                case "MUSIC CHOICE VIDEO":
                    return CategoryName.MusicChoiceVideo;
                case "NHL PLAYOFFS":
                    return CategoryName.NhlPlayoffs;
                case "PPV | SPECIAL EVENTS":
                    return CategoryName.PpvSpecialEvents;
                case "UK CHANNELS":
                    return CategoryName.UkChannels;
                case "USA 2 CHANNELS":
                    return CategoryName.Usa2Channels;
                case "USA CHANNELS":
                    return CategoryName.UsaChannels;
                case "USA SD CHANNELS":
                    return CategoryName.UsaSdChannels;
                case "USA SPORTS":
                    return CategoryName.UsaSports;
                case "xxx CHANNELS xxx":
                    return CategoryName.XxxChannelsXxx;
                default:
                    return CategoryName.Other;
            }
            throw new Exception("Cannot unmarshal type CategoryName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CategoryName)untypedValue;
            switch (value)
            {
                case CategoryName.The247:
                    serializer.Serialize(writer, "24/7");
                    return;
                case CategoryName.The247Kids:
                    serializer.Serialize(writer, "24/7 KIDS");
                    return;
                case CategoryName.CanadianChannels:
                    serializer.Serialize(writer, "CANADIAN CHANNELS");
                    return;
                case CategoryName.EspnSports:
                    serializer.Serialize(writer, "ESPN SPORTS");
                    return;
                case CategoryName.InternationalSports:
                    serializer.Serialize(writer, "INTERNATIONAL SPORTS");
                    return;
                case CategoryName.LocalChannels:
                    serializer.Serialize(writer, "LOCAL CHANNELS");
                    return;
                case CategoryName.MlbChannels:
                    serializer.Serialize(writer, "MLB CHANNELS");
                    return;
                case CategoryName.MusicChoiceVideo:
                    serializer.Serialize(writer, "MUSIC CHOICE VIDEO");
                    return;
                case CategoryName.NhlPlayoffs:
                    serializer.Serialize(writer, "NHL PLAYOFFS");
                    return;
                case CategoryName.PpvSpecialEvents:
                    serializer.Serialize(writer, "PPV | SPECIAL EVENTS");
                    return;
                case CategoryName.UkChannels:
                    serializer.Serialize(writer, "UK CHANNELS");
                    return;
                case CategoryName.Usa2Channels:
                    serializer.Serialize(writer, "USA 2 CHANNELS");
                    return;
                case CategoryName.UsaChannels:
                    serializer.Serialize(writer, "USA CHANNELS");
                    return;
                case CategoryName.UsaSdChannels:
                    serializer.Serialize(writer, "USA SD CHANNELS");
                    return;
                case CategoryName.UsaSports:
                    serializer.Serialize(writer, "USA SPORTS");
                    return;
                case CategoryName.XxxChannelsXxx:
                    serializer.Serialize(writer, "xxx CHANNELS xxx");
                    return;
            }
            throw new Exception("Cannot marshal type CategoryName");
        }

        public static readonly CategoryNameConverter Singleton = new CategoryNameConverter();
    }

    internal class StreamTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreamType) || t == typeof(StreamType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "created_live":
                    return StreamType.CreatedLive;
                case "live":
                    return StreamType.Live;
                case "movie":
                    return StreamType.Movie;
                case "radio_streams":
                    return StreamType.RadioStreams;
            }
            throw new Exception("Cannot unmarshal type StreamType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreamType)untypedValue;
            if (value == StreamType.Live)
            {
                serializer.Serialize(writer, "live");
                return;
            }
            throw new Exception("Cannot marshal type StreamType");
        }

        public static readonly StreamTypeConverter Singleton = new StreamTypeConverter();
    }

    internal class TypeNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeName) || t == typeof(TypeName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Created Live Channels":
                    return TypeName.CreatedLiveChannels;
                case "Live Streams":
                    return TypeName.LiveStreams;
                case "Movies":
                    return TypeName.Movies;
                case "Radio":
                    return TypeName.Radio;
            }
            throw new Exception("Cannot unmarshal type TypeName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeName)untypedValue;
            if (value == TypeName.LiveStreams)
            {
                serializer.Serialize(writer, "Live Streams");
                return;
            }
            throw new Exception("Cannot marshal type TypeName");
        }

        public static readonly TypeNameConverter Singleton = new TypeNameConverter();
    }
}

