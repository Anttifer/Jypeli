using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jypeli.Content
{
    internal static class Lighting
    {
        public static byte[] rawData = {
  0x4d, 0x47, 0x46, 0x58, 0x07, 0x00, 0xc2, 0x96, 0xef, 0xdd, 0x02, 0x10,
  0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f,
  0x76, 0x65, 0x63, 0x34, 0x30, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0x10,
  0x00, 0x02, 0x20, 0x00, 0x10, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x80, 0x00, 0x02,
  0x03, 0x00, 0x00, 0x04, 0x40, 0x00, 0x04, 0x00, 0x05, 0x03, 0x00, 0x00,
  0x23, 0x69, 0x66, 0x64, 0x65, 0x66, 0x20, 0x47, 0x4c, 0x5f, 0x45, 0x53,
  0x0d, 0x0a, 0x70, 0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x20,
  0x6d, 0x65, 0x64, 0x69, 0x75, 0x6d, 0x70, 0x20, 0x66, 0x6c, 0x6f, 0x61,
  0x74, 0x3b, 0x0d, 0x0a, 0x70, 0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f,
  0x6e, 0x20, 0x6d, 0x65, 0x64, 0x69, 0x75, 0x6d, 0x70, 0x20, 0x69, 0x6e,
  0x74, 0x3b, 0x0d, 0x0a, 0x23, 0x65, 0x6e, 0x64, 0x69, 0x66, 0x0d, 0x0a,
  0x0d, 0x0a, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x20, 0x76, 0x65,
  0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72,
  0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x33, 0x5d, 0x3b, 0x0d,
  0x0a, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x3b,
  0x0d, 0x0a, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x31,
  0x3b, 0x0d, 0x0a, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x72,
  0x32, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20,
  0x70, 0x73, 0x5f, 0x63, 0x30, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69,
  0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x30,
  0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x70,
  0x73, 0x5f, 0x63, 0x31, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x31, 0x5d,
  0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x70, 0x73,
  0x5f, 0x63, 0x32, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f,
  0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x32, 0x5d, 0x0d,
  0x0a, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x20, 0x73, 0x61, 0x6d,
  0x70, 0x6c, 0x65, 0x72, 0x32, 0x44, 0x20, 0x70, 0x73, 0x5f, 0x73, 0x30,
  0x3b, 0x0d, 0x0a, 0x76, 0x61, 0x72, 0x79, 0x69, 0x6e, 0x67, 0x20, 0x76,
  0x65, 0x63, 0x34, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72,
  0x64, 0x30, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65,
  0x20, 0x70, 0x73, 0x5f, 0x74, 0x30, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43,
  0x6f, 0x6f, 0x72, 0x64, 0x30, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69,
  0x6e, 0x65, 0x20, 0x70, 0x73, 0x5f, 0x6f, 0x43, 0x30, 0x20, 0x67, 0x6c,
  0x5f, 0x46, 0x72, 0x61, 0x67, 0x43, 0x6f, 0x6c, 0x6f, 0x72, 0x0d, 0x0a,
  0x76, 0x61, 0x72, 0x79, 0x69, 0x6e, 0x67, 0x20, 0x76, 0x65, 0x63, 0x34,
  0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72, 0x64, 0x32, 0x3b,
  0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x70, 0x73,
  0x5f, 0x74, 0x32, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72,
  0x64, 0x32, 0x0d, 0x0a, 0x0d, 0x0a, 0x76, 0x6f, 0x69, 0x64, 0x20, 0x6d,
  0x61, 0x69, 0x6e, 0x28, 0x29, 0x0d, 0x0a, 0x7b, 0x0d, 0x0a, 0x09, 0x70,
  0x73, 0x5f, 0x72, 0x30, 0x20, 0x3d, 0x20, 0x74, 0x65, 0x78, 0x74, 0x75,
  0x72, 0x65, 0x32, 0x44, 0x28, 0x70, 0x73, 0x5f, 0x73, 0x30, 0x2c, 0x20,
  0x70, 0x73, 0x5f, 0x74, 0x30, 0x2e, 0x78, 0x79, 0x29, 0x3b, 0x0d, 0x0a,
  0x09, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x79, 0x7a, 0x20, 0x3d,
  0x20, 0x70, 0x73, 0x5f, 0x74, 0x32, 0x2e, 0x78, 0x79, 0x7a, 0x20, 0x2b,
  0x20, 0x2d, 0x70, 0x73, 0x5f, 0x63, 0x30, 0x2e, 0x78, 0x79, 0x7a, 0x3b,
  0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x20, 0x3d,
  0x20, 0x64, 0x6f, 0x74, 0x28, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78,
  0x79, 0x7a, 0x2c, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x79,
  0x7a, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e,
  0x78, 0x20, 0x3d, 0x20, 0x69, 0x6e, 0x76, 0x65, 0x72, 0x73, 0x65, 0x73,
  0x71, 0x72, 0x74, 0x28, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x29,
  0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x20,
  0x3d, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x20, 0x2a, 0x20,
  0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x7a, 0x3b, 0x0d, 0x0a, 0x09, 0x70,
  0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x63, 0x6c, 0x61,
  0x6d, 0x70, 0x28, 0x2d, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x2c,
  0x20, 0x30, 0x2e, 0x30, 0x2c, 0x20, 0x31, 0x2e, 0x30, 0x29, 0x3b, 0x0d,
  0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x32, 0x2e, 0x77, 0x20, 0x3d, 0x20,
  0x70, 0x73, 0x5f, 0x63, 0x31, 0x2e, 0x78, 0x3b, 0x0d, 0x0a, 0x09, 0x70,
  0x73, 0x5f, 0x72, 0x31, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x28, 0x70, 0x73,
  0x5f, 0x72, 0x31, 0x2e, 0x78, 0x20, 0x2a, 0x20, 0x70, 0x73, 0x5f, 0x72,
  0x32, 0x2e, 0x77, 0x29, 0x20, 0x2b, 0x20, 0x70, 0x73, 0x5f, 0x63, 0x32,
  0x2e, 0x78, 0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e,
  0x78, 0x79, 0x7a, 0x20, 0x3d, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e,
  0x78, 0x79, 0x7a, 0x20, 0x2a, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e,
  0x78, 0x78, 0x78, 0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x6f, 0x43,
  0x30, 0x20, 0x3d, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x3b, 0x0d, 0x0a,
  0x7d, 0x0d, 0x0a, 0x0d, 0x0a, 0x01, 0x00, 0x00, 0x00, 0x01, 0x02, 0x02,
  0x00, 0xff, 0xff, 0xff, 0xff, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x70, 0x73, 0x5f, 0x73, 0x30,
  0x05, 0x01, 0x00, 0x00, 0x01, 0xd7, 0x03, 0x00, 0x00, 0x23, 0x69, 0x66,
  0x64, 0x65, 0x66, 0x20, 0x47, 0x4c, 0x5f, 0x45, 0x53, 0x0d, 0x0a, 0x70,
  0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x68, 0x69, 0x67,
  0x68, 0x70, 0x20, 0x66, 0x6c, 0x6f, 0x61, 0x74, 0x3b, 0x0d, 0x0a, 0x70,
  0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x6d, 0x65, 0x64,
  0x69, 0x75, 0x6d, 0x70, 0x20, 0x69, 0x6e, 0x74, 0x3b, 0x0d, 0x0a, 0x23,
  0x65, 0x6e, 0x64, 0x69, 0x66, 0x0d, 0x0a, 0x0d, 0x0a, 0x75, 0x6e, 0x69,
  0x66, 0x6f, 0x72, 0x6d, 0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x76, 0x73,
  0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65,
  0x63, 0x34, 0x5b, 0x37, 0x5d, 0x3b, 0x0d, 0x0a, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x6f, 0x73,
  0x46, 0x69, 0x78, 0x75, 0x70, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66,
  0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x30, 0x20, 0x76, 0x73,
  0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65,
  0x63, 0x34, 0x5b, 0x30, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69,
  0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x31, 0x20, 0x76, 0x73, 0x5f,
  0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63,
  0x34, 0x5b, 0x31, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e,
  0x65, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x32, 0x20, 0x76, 0x73, 0x5f, 0x75,
  0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34,
  0x5b, 0x32, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65,
  0x20, 0x76, 0x73, 0x5f, 0x63, 0x33, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e,
  0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b,
  0x33, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20,
  0x76, 0x73, 0x5f, 0x63, 0x34, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69,
  0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x34,
  0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76,
  0x73, 0x5f, 0x63, 0x35, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x35, 0x5d,
  0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76, 0x73,
  0x5f, 0x63, 0x36, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f,
  0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x36, 0x5d, 0x0d,
  0x0a, 0x61, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x20, 0x76,
  0x65, 0x63, 0x34, 0x20, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x3b, 0x0d, 0x0a,
  0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x6f,
  0x50, 0x6f, 0x73, 0x20, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74,
  0x69, 0x6f, 0x6e, 0x0d, 0x0a, 0x76, 0x61, 0x72, 0x79, 0x69, 0x6e, 0x67,
  0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f,
  0x6f, 0x72, 0x64, 0x30, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69,
  0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x6f, 0x54, 0x30, 0x20, 0x76, 0x54,
  0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72, 0x64, 0x30, 0x0d, 0x0a, 0x61, 0x74,
  0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x20, 0x76, 0x65, 0x63, 0x34,
  0x20, 0x76, 0x73, 0x5f, 0x76, 0x31, 0x3b, 0x0d, 0x0a, 0x76, 0x61, 0x72,
  0x79, 0x69, 0x6e, 0x67, 0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x76, 0x54,
  0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72, 0x64, 0x32, 0x3b, 0x0d, 0x0a, 0x23,
  0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x6f, 0x54,
  0x32, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72, 0x64, 0x32,
  0x0d, 0x0a, 0x0d, 0x0a, 0x76, 0x6f, 0x69, 0x64, 0x20, 0x6d, 0x61, 0x69,
  0x6e, 0x28, 0x29, 0x0d, 0x0a, 0x7b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f,
  0x6f, 0x50, 0x6f, 0x73, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74,
  0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63,
  0x30, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x50, 0x6f,
  0x73, 0x2e, 0x79, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73,
  0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x31, 0x29, 0x3b,
  0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x50, 0x6f, 0x73, 0x2e, 0x7a,
  0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30,
  0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x32, 0x29, 0x3b, 0x0d, 0x0a, 0x09,
  0x76, 0x73, 0x5f, 0x6f, 0x50, 0x6f, 0x73, 0x2e, 0x77, 0x20, 0x3d, 0x20,
  0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76,
  0x73, 0x5f, 0x63, 0x33, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f,
  0x6f, 0x54, 0x32, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28,
  0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x34,
  0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x54, 0x32, 0x2e,
  0x79, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76,
  0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x35, 0x29, 0x3b, 0x0d, 0x0a,
  0x09, 0x76, 0x73, 0x5f, 0x6f, 0x54, 0x32, 0x2e, 0x7a, 0x20, 0x3d, 0x20,
  0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76,
  0x73, 0x5f, 0x63, 0x36, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f,
  0x6f, 0x54, 0x30, 0x2e, 0x78, 0x79, 0x20, 0x3d, 0x20, 0x76, 0x73, 0x5f,
  0x76, 0x31, 0x2e, 0x78, 0x79, 0x3b, 0x0d, 0x0a, 0x09, 0x67, 0x6c, 0x5f,
  0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x79, 0x20, 0x3d,
  0x20, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e,
  0x2e, 0x79, 0x20, 0x2a, 0x20, 0x70, 0x6f, 0x73, 0x46, 0x69, 0x78, 0x75,
  0x70, 0x2e, 0x79, 0x3b, 0x0d, 0x0a, 0x09, 0x67, 0x6c, 0x5f, 0x50, 0x6f,
  0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x78, 0x79, 0x20, 0x2b, 0x3d,
  0x20, 0x70, 0x6f, 0x73, 0x46, 0x69, 0x78, 0x75, 0x70, 0x2e, 0x7a, 0x77,
  0x20, 0x2a, 0x20, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69,
  0x6f, 0x6e, 0x2e, 0x77, 0x77, 0x3b, 0x0d, 0x0a, 0x09, 0x67, 0x6c, 0x5f,
  0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x7a, 0x20, 0x3d,
  0x20, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e,
  0x2e, 0x7a, 0x20, 0x2a, 0x20, 0x32, 0x2e, 0x30, 0x20, 0x2d, 0x20, 0x67,
  0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x77,
  0x3b, 0x0d, 0x0a, 0x7d, 0x0d, 0x0a, 0x0d, 0x0a, 0x00, 0x01, 0x01, 0x02,
  0x05, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x00, 0x00, 0x00, 0x00, 0x05, 0x76,
  0x73, 0x5f, 0x76, 0x31, 0x02, 0x00, 0x00, 0x00, 0x00, 0xcf, 0x02, 0x00,
  0x00, 0x23, 0x69, 0x66, 0x64, 0x65, 0x66, 0x20, 0x47, 0x4c, 0x5f, 0x45,
  0x53, 0x0d, 0x0a, 0x70, 0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f, 0x6e,
  0x20, 0x6d, 0x65, 0x64, 0x69, 0x75, 0x6d, 0x70, 0x20, 0x66, 0x6c, 0x6f,
  0x61, 0x74, 0x3b, 0x0d, 0x0a, 0x70, 0x72, 0x65, 0x63, 0x69, 0x73, 0x69,
  0x6f, 0x6e, 0x20, 0x6d, 0x65, 0x64, 0x69, 0x75, 0x6d, 0x70, 0x20, 0x69,
  0x6e, 0x74, 0x3b, 0x0d, 0x0a, 0x23, 0x65, 0x6e, 0x64, 0x69, 0x66, 0x0d,
  0x0a, 0x0d, 0x0a, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x20, 0x76,
  0x65, 0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f,
  0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x33, 0x5d, 0x3b,
  0x0d, 0x0a, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x30,
  0x3b, 0x0d, 0x0a, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x73, 0x5f, 0x72,
  0x31, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20,
  0x70, 0x73, 0x5f, 0x63, 0x30, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69,
  0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x30,
  0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x70,
  0x73, 0x5f, 0x63, 0x31, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x31, 0x5d,
  0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x70, 0x73,
  0x5f, 0x63, 0x32, 0x20, 0x70, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f,
  0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x32, 0x5d, 0x0d,
  0x0a, 0x76, 0x61, 0x72, 0x79, 0x69, 0x6e, 0x67, 0x20, 0x76, 0x65, 0x63,
  0x34, 0x20, 0x76, 0x46, 0x72, 0x6f, 0x6e, 0x74, 0x43, 0x6f, 0x6c, 0x6f,
  0x72, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20,
  0x70, 0x73, 0x5f, 0x76, 0x30, 0x20, 0x76, 0x46, 0x72, 0x6f, 0x6e, 0x74,
  0x43, 0x6f, 0x6c, 0x6f, 0x72, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69,
  0x6e, 0x65, 0x20, 0x70, 0x73, 0x5f, 0x6f, 0x43, 0x30, 0x20, 0x67, 0x6c,
  0x5f, 0x46, 0x72, 0x61, 0x67, 0x43, 0x6f, 0x6c, 0x6f, 0x72, 0x0d, 0x0a,
  0x76, 0x61, 0x72, 0x79, 0x69, 0x6e, 0x67, 0x20, 0x76, 0x65, 0x63, 0x34,
  0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72, 0x64, 0x32, 0x3b,
  0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x70, 0x73,
  0x5f, 0x74, 0x32, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72,
  0x64, 0x32, 0x0d, 0x0a, 0x0d, 0x0a, 0x76, 0x6f, 0x69, 0x64, 0x20, 0x6d,
  0x61, 0x69, 0x6e, 0x28, 0x29, 0x0d, 0x0a, 0x7b, 0x0d, 0x0a, 0x09, 0x70,
  0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x79, 0x7a, 0x20, 0x3d, 0x20, 0x70,
  0x73, 0x5f, 0x74, 0x32, 0x2e, 0x78, 0x79, 0x7a, 0x20, 0x2b, 0x20, 0x2d,
  0x70, 0x73, 0x5f, 0x63, 0x30, 0x2e, 0x78, 0x79, 0x7a, 0x3b, 0x0d, 0x0a,
  0x09, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x64,
  0x6f, 0x74, 0x28, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x79, 0x7a,
  0x2c, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x79, 0x7a, 0x29,
  0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x20,
  0x3d, 0x20, 0x69, 0x6e, 0x76, 0x65, 0x72, 0x73, 0x65, 0x73, 0x71, 0x72,
  0x74, 0x28, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x29, 0x3b, 0x0d,
  0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x20, 0x3d, 0x20,
  0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x20, 0x2a, 0x20, 0x70, 0x73,
  0x5f, 0x72, 0x30, 0x2e, 0x7a, 0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f,
  0x72, 0x30, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x63, 0x6c, 0x61, 0x6d, 0x70,
  0x28, 0x2d, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x2c, 0x20, 0x30,
  0x2e, 0x30, 0x2c, 0x20, 0x31, 0x2e, 0x30, 0x29, 0x3b, 0x0d, 0x0a, 0x09,
  0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e, 0x77, 0x20, 0x3d, 0x20, 0x70, 0x73,
  0x5f, 0x63, 0x31, 0x2e, 0x78, 0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f,
  0x72, 0x30, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x28, 0x70, 0x73, 0x5f, 0x72,
  0x30, 0x2e, 0x78, 0x20, 0x2a, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x31, 0x2e,
  0x77, 0x29, 0x20, 0x2b, 0x20, 0x70, 0x73, 0x5f, 0x63, 0x32, 0x2e, 0x78,
  0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x79,
  0x7a, 0x20, 0x3d, 0x20, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x78, 0x78,
  0x78, 0x20, 0x2a, 0x20, 0x70, 0x73, 0x5f, 0x76, 0x30, 0x2e, 0x78, 0x79,
  0x7a, 0x3b, 0x0d, 0x0a, 0x09, 0x70, 0x73, 0x5f, 0x72, 0x30, 0x2e, 0x77,
  0x20, 0x3d, 0x20, 0x70, 0x73, 0x5f, 0x76, 0x30, 0x2e, 0x77, 0x3b, 0x0d,
  0x0a, 0x09, 0x70, 0x73, 0x5f, 0x6f, 0x43, 0x30, 0x20, 0x3d, 0x20, 0x70,
  0x73, 0x5f, 0x72, 0x30, 0x3b, 0x0d, 0x0a, 0x7d, 0x0d, 0x0a, 0x0d, 0x0a,
  0x00, 0x01, 0x00, 0x00, 0x01, 0xd3, 0x03, 0x00, 0x00, 0x23, 0x69, 0x66,
  0x64, 0x65, 0x66, 0x20, 0x47, 0x4c, 0x5f, 0x45, 0x53, 0x0d, 0x0a, 0x70,
  0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x68, 0x69, 0x67,
  0x68, 0x70, 0x20, 0x66, 0x6c, 0x6f, 0x61, 0x74, 0x3b, 0x0d, 0x0a, 0x70,
  0x72, 0x65, 0x63, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x6d, 0x65, 0x64,
  0x69, 0x75, 0x6d, 0x70, 0x20, 0x69, 0x6e, 0x74, 0x3b, 0x0d, 0x0a, 0x23,
  0x65, 0x6e, 0x64, 0x69, 0x66, 0x0d, 0x0a, 0x0d, 0x0a, 0x75, 0x6e, 0x69,
  0x66, 0x6f, 0x72, 0x6d, 0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x76, 0x73,
  0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65,
  0x63, 0x34, 0x5b, 0x37, 0x5d, 0x3b, 0x0d, 0x0a, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x70, 0x6f, 0x73,
  0x46, 0x69, 0x78, 0x75, 0x70, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66,
  0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x30, 0x20, 0x76, 0x73,
  0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65,
  0x63, 0x34, 0x5b, 0x30, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69,
  0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x31, 0x20, 0x76, 0x73, 0x5f,
  0x75, 0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63,
  0x34, 0x5b, 0x31, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e,
  0x65, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x32, 0x20, 0x76, 0x73, 0x5f, 0x75,
  0x6e, 0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34,
  0x5b, 0x32, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65,
  0x20, 0x76, 0x73, 0x5f, 0x63, 0x33, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e,
  0x69, 0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b,
  0x33, 0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20,
  0x76, 0x73, 0x5f, 0x63, 0x34, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69,
  0x66, 0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x34,
  0x5d, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76,
  0x73, 0x5f, 0x63, 0x35, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66,
  0x6f, 0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x35, 0x5d,
  0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76, 0x73,
  0x5f, 0x63, 0x36, 0x20, 0x76, 0x73, 0x5f, 0x75, 0x6e, 0x69, 0x66, 0x6f,
  0x72, 0x6d, 0x73, 0x5f, 0x76, 0x65, 0x63, 0x34, 0x5b, 0x36, 0x5d, 0x0d,
  0x0a, 0x61, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x20, 0x76,
  0x65, 0x63, 0x34, 0x20, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x3b, 0x0d, 0x0a,
  0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x6f,
  0x50, 0x6f, 0x73, 0x20, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74,
  0x69, 0x6f, 0x6e, 0x0d, 0x0a, 0x76, 0x61, 0x72, 0x79, 0x69, 0x6e, 0x67,
  0x20, 0x76, 0x65, 0x63, 0x34, 0x20, 0x76, 0x46, 0x72, 0x6f, 0x6e, 0x74,
  0x43, 0x6f, 0x6c, 0x6f, 0x72, 0x3b, 0x0d, 0x0a, 0x23, 0x64, 0x65, 0x66,
  0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f, 0x6f, 0x44, 0x30, 0x20, 0x76,
  0x46, 0x72, 0x6f, 0x6e, 0x74, 0x43, 0x6f, 0x6c, 0x6f, 0x72, 0x0d, 0x0a,
  0x61, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x20, 0x76, 0x65,
  0x63, 0x34, 0x20, 0x76, 0x73, 0x5f, 0x76, 0x31, 0x3b, 0x0d, 0x0a, 0x76,
  0x61, 0x72, 0x79, 0x69, 0x6e, 0x67, 0x20, 0x76, 0x65, 0x63, 0x34, 0x20,
  0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72, 0x64, 0x32, 0x3b, 0x0d,
  0x0a, 0x23, 0x64, 0x65, 0x66, 0x69, 0x6e, 0x65, 0x20, 0x76, 0x73, 0x5f,
  0x6f, 0x54, 0x32, 0x20, 0x76, 0x54, 0x65, 0x78, 0x43, 0x6f, 0x6f, 0x72,
  0x64, 0x32, 0x0d, 0x0a, 0x0d, 0x0a, 0x76, 0x6f, 0x69, 0x64, 0x20, 0x6d,
  0x61, 0x69, 0x6e, 0x28, 0x29, 0x0d, 0x0a, 0x7b, 0x0d, 0x0a, 0x09, 0x76,
  0x73, 0x5f, 0x6f, 0x50, 0x6f, 0x73, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x64,
  0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73,
  0x5f, 0x63, 0x30, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f,
  0x50, 0x6f, 0x73, 0x2e, 0x79, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28,
  0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x31,
  0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x50, 0x6f, 0x73,
  0x2e, 0x7a, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f,
  0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x32, 0x29, 0x3b, 0x0d,
  0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x50, 0x6f, 0x73, 0x2e, 0x77, 0x20,
  0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c,
  0x20, 0x76, 0x73, 0x5f, 0x63, 0x33, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76,
  0x73, 0x5f, 0x6f, 0x54, 0x32, 0x2e, 0x78, 0x20, 0x3d, 0x20, 0x64, 0x6f,
  0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f,
  0x63, 0x34, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x54,
  0x32, 0x2e, 0x79, 0x20, 0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73,
  0x5f, 0x76, 0x30, 0x2c, 0x20, 0x76, 0x73, 0x5f, 0x63, 0x35, 0x29, 0x3b,
  0x0d, 0x0a, 0x09, 0x76, 0x73, 0x5f, 0x6f, 0x54, 0x32, 0x2e, 0x7a, 0x20,
  0x3d, 0x20, 0x64, 0x6f, 0x74, 0x28, 0x76, 0x73, 0x5f, 0x76, 0x30, 0x2c,
  0x20, 0x76, 0x73, 0x5f, 0x63, 0x36, 0x29, 0x3b, 0x0d, 0x0a, 0x09, 0x76,
  0x73, 0x5f, 0x6f, 0x44, 0x30, 0x20, 0x3d, 0x20, 0x76, 0x73, 0x5f, 0x76,
  0x31, 0x3b, 0x0d, 0x0a, 0x09, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69,
  0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x79, 0x20, 0x3d, 0x20, 0x67, 0x6c, 0x5f,
  0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x79, 0x20, 0x2a,
  0x20, 0x70, 0x6f, 0x73, 0x46, 0x69, 0x78, 0x75, 0x70, 0x2e, 0x79, 0x3b,
  0x0d, 0x0a, 0x09, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69,
  0x6f, 0x6e, 0x2e, 0x78, 0x79, 0x20, 0x2b, 0x3d, 0x20, 0x70, 0x6f, 0x73,
  0x46, 0x69, 0x78, 0x75, 0x70, 0x2e, 0x7a, 0x77, 0x20, 0x2a, 0x20, 0x67,
  0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x77,
  0x77, 0x3b, 0x0d, 0x0a, 0x09, 0x67, 0x6c, 0x5f, 0x50, 0x6f, 0x73, 0x69,
  0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x7a, 0x20, 0x3d, 0x20, 0x67, 0x6c, 0x5f,
  0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x7a, 0x20, 0x2a,
  0x20, 0x32, 0x2e, 0x30, 0x20, 0x2d, 0x20, 0x67, 0x6c, 0x5f, 0x50, 0x6f,
  0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x77, 0x3b, 0x0d, 0x0a, 0x7d,
  0x0d, 0x0a, 0x0d, 0x0a, 0x00, 0x01, 0x01, 0x02, 0x05, 0x76, 0x73, 0x5f,
  0x76, 0x30, 0x00, 0x00, 0x00, 0x00, 0x05, 0x76, 0x73, 0x5f, 0x76, 0x31,
  0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x09, 0x78, 0x4c, 0x69, 0x67,
  0x68, 0x74, 0x50, 0x6f, 0x73, 0x00, 0x00, 0x01, 0x03, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x03, 0x0b, 0x78, 0x4c, 0x69, 0x67, 0x68, 0x74, 0x50, 0x6f, 0x77, 0x65,
  0x72, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x03, 0x08, 0x78, 0x41, 0x6d, 0x62, 0x69, 0x65, 0x6e, 0x74, 0x00, 0x00,
  0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x03, 0x14, 0x78,
  0x57, 0x6f, 0x72, 0x6c, 0x64, 0x56, 0x69, 0x65, 0x77, 0x50, 0x72, 0x6f,
  0x6a, 0x65, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x00, 0x00, 0x04, 0x04, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x03, 0x06, 0x78, 0x57, 0x6f, 0x72,
  0x6c, 0x64, 0x00, 0x00, 0x04, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x03, 0x07, 0x08, 0x78, 0x54, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x0f, 0x54, 0x65, 0x78, 0x74, 0x75,
  0x72, 0x65, 0x4c, 0x69, 0x67, 0x68, 0x74, 0x69, 0x6e, 0x67, 0x00, 0x01,
  0x05, 0x50, 0x61, 0x73, 0x73, 0x30, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00,
  0x0d, 0x43, 0x6f, 0x6c, 0x6f, 0x72, 0x4c, 0x69, 0x67, 0x68, 0x74, 0x69,
  0x6e, 0x67, 0x00, 0x01, 0x05, 0x50, 0x61, 0x73, 0x73, 0x30, 0x00, 0x03,
  0x02, 0x00, 0x00, 0x00
};
    }
}
