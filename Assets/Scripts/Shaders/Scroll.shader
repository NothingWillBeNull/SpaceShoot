Shader"Custom/ScrollingBackground" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _Speed ("Scroll Speed", Range(-1, 1)) = 1
    }

    SubShader {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard

sampler2D _MainTex;
float _Speed;

struct Input
{
    float2 uv_MainTex;
    float3 worldPos;
    float3 worldNormal;
};

void surf(Input IN, inout SurfaceOutputStandard o)
{
    float2 offset = IN.worldPos.xz * _Speed;
    o.Albedo = tex2D(_MainTex, IN.uv_MainTex + offset).rgb;
    o.Alpha = tex2D(_MainTex, IN.uv_MainTex + offset).a;
}
        ENDCG
    }
FallBack"Diffuse"
}
