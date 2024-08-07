# antlrTest
antlr4  Test by tpantlr2 （base tpantlr2 run error ）


## env

change Antlr4BuildTasks.targets

```
    <ItemDefinitionGroup>
        <Antlr4>
            <AllowAntlr4cs>false</AllowAntlr4cs>
            <AntlrToolJar></AntlrToolJar>
			<AntlrToolJarDownloadDir>D:\java\m2\</AntlrToolJarDownloadDir>
            <AntOutDir></AntOutDir>
            <CopyToOutputDirectory>Never</CopyToOutputDirectory>
            <DOptions>language=CSharp</DOptions>
            <Encoding>UTF-8</Encoding>
            <Error>false</Error>
            <ForceAtn>false</ForceAtn>
            <GAtn>false</GAtn>
            <Generator>MSBuild:Compile</Generator>
            <IntermediateOutputPath>$(IntermediateOutputPath)</IntermediateOutputPath>
            <JavaDownloadDirectory>D:\java\jre\</JavaDownloadDirectory>
            <JavaExec>PATH;DOWNLOAD</JavaExec>
            <LibPath></LibPath>
            <Listener>true</Listener>
            <Log>false</Log>
            <LongMessages>false</LongMessages>
            <Package></Package>
            <Visitor>true</Visitor>
        </Antlr4>
    </ItemDefinitionGroup>

```

in china use  proxy 