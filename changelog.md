# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [3.0.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/3.0.0) - 2021-01-10  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/7?closed=1)  
    

### Changed

- Update serialize package ([#26](https://github.com/unity-game-framework/ugf-module-serialize/pull/26))  
    - Update `com.ugf.serialize` up to `3.0.2` version.
    - Change `SerializeModule` to work with update serializer builders.

## [2.0.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/2.0.0) - 2020-12-05  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/6?closed=1)  
    

### Changed

- Update to support latest application package ([#23](https://github.com/unity-game-framework/ugf-module-serialize/pull/23))  
    - Update to use `UGF.Builder` and `UGF.Description` packages from the latest version of `UGF.Application` package.
    - Change dependencies: `com.ugf.application` to `6.0.0`, `com.ugf.serialize` to `2.0.0`, `com.ugf.logs` to `4.1.0`.
    - Change name of the root of create assets menu, from `UGF` to `Unity Game Framework`.

## [1.1.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/1.1.0) - 2020-10-26  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/5?closed=1)  
    

### Changed

- Change SerializeModule to have typed description ([#17](https://github.com/unity-game-framework/ugf-module-serialize/pull/17))  
    - Change `SerializeModule` to receive `SerializeModuleDescription` type of description instead of `ISerializeModuleDescription`.
    - Change `SerializeModuleAsset` to build `SerializeModuleDescription` type of description instead of `ISerializeModuleDescription`.
    - Add `ISerializeModule.Description` property with return type of `ISerializeModuleDescription `.
- Change module asset creation menu path ([#16](https://github.com/unity-game-framework/ugf-module-serialize/pull/16))  
    - Rename menu to `UGF/Serialize/Serialize Module`.

## [1.0.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/1.0.0) - 2020-10-22  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/4?closed=1)  
    

### Changed

- Rework module to support updated Application and Serializers ([#12](https://github.com/unity-game-framework/ugf-module-serialize/pull/12))  
    - Rework `ISerializeModule` to support updated `UGF.Application` and `UGF.Serialize` packages, now module create specified serializers and register them by name in provider.
    - Rework `ISerializeModuleDescription` to store serializer builders by id.
    - Replace `SerializeModuleInfoAsset` by `SerializeModuleAsset`.
    - Update dependencies: `com.ugf.application` to `5.1.0`, `com.ugf.serialize` to `1.2.0`.
    - Add dependency: `com.ugf.logs` of `3.0.0`.
- Update to Unity 2020.2 ([#10](https://github.com/unity-game-framework/ugf-module-serialize/pull/10))

## [0.3.0-preview](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/0.3.0-preview) - 2019-12-09  

- [Commits](https://github.com/unity-game-framework/ugf-module-serialize/compare/0.2.0-preview...0.3.0-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/3?closed=1)

### Added
- Package dependencies:
    - `com.ugf.application`: `3.0.0-preview`.

### Changed
- Update `UGF.Application` package.

### Removed
- Package dependencies:
    - `com.ugf.module`: `0.2.0-preview`.

## [0.2.0-preview](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/0.2.0-preview) - 2019-11-23  

- [Commits](https://github.com/unity-game-framework/ugf-module-serialize/compare/0.1.0-preview...0.2.0-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/2?closed=1)

### Changed
- Package dependencies:
    - `com.ugf.module`: from `0.1.0-preview` to `0.2.0-preview`.
    - `com.ugf.serialize`: from `1.0.0-preview.2` to `1.1.0-preview`.

## [0.1.0-preview](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/0.1.0-preview) - 2019-10-09  

- [Commits](https://github.com/unity-game-framework/ugf-module-serialize/compare/1feb71e...0.1.0-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/1?closed=1)

### Added
- This is a initial release.


