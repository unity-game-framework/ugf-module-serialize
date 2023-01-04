# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [5.0.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/5.0.0) - 2023-01-04  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/13?closed=1)  
    

### Changed

- Update project ([#39](https://github.com/unity-game-framework/ugf-module-serialize/issues/39))  
    - Update dependencies: `com.ugf.application` to `8.4.0`, `com.ugf.serialize` to `5.3.1` and `com.ugf.editortools` to `2.15.0` versions.
    - Update package _Unity_ version to `2022.2`.
    - Change `SerializeModuleAsset` class inspector to support selection preview and replacements.

## [5.0.0-preview](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/5.0.0-preview) - 2022-07-14  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/12?closed=1)  
    

### Changed

- Change string ids to global id data ([#37](https://github.com/unity-game-framework/ugf-module-serialize/issues/37))  
    - Update dependencies: `com.ugf.application` to `8.3.0`, `com.ugf.serialize` to `5.1.0` and `com.ugf.editortools` to `2.8.1` versions.
    - Update package _Unity_ version to `2022.1`.
    - Change usage of ids as `GlobalId` structure instead of `string`.

## [4.0.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/4.0.0) - 2021-11-29  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/11?closed=1)  
    

### Changed

- Update dependencies ([#36](https://github.com/unity-game-framework/ugf-module-serialize/pull/36))  
    - Update package _Unity_ version to `2021.2`.
    - Update dependencies: `com.ugf.application` to `8.0.0` and `com.ugf.serialize` to `5.0.0` versions.

## [4.0.0-preview.1](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/4.0.0-preview.1) - 2021-07-24  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/10?closed=1)  
    

### Changed

- Update for latest serialize package ([#34](https://github.com/unity-game-framework/ugf-module-serialize/pull/34))  
    - Update dependencies: `com.ugf.application` to `8.0.0-preview.8` version and `com.ugf.serialize` to `5.0.0-preview` version.
    - Add `ISerializeModule.Context` property to use with any serializer.

## [4.0.0-preview](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/4.0.0-preview) - 2021-03-02  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/9?closed=1)  
    

### Changed

- Rework provider and update application ([#32](https://github.com/unity-game-framework/ugf-module-serialize/pull/32))  
    - Update project to _Unity_ of `2021.1` version.
    - Update package publish registry.
    - Change dependencies: `com.ugf.application` to `8.0.0-preview.4`.
    - Replace `ISerializerProvider ` provider by `IProvider<string, ISerializer>` interface from _UGF.RuntimeTools_ package.
    - Remove `GetSerializerBuilder` and `TryGetSerializerBuilder` methods from `SerializeModule ` class and `ISerializeModule` interface.

## [3.1.0](https://github.com/unity-game-framework/ugf-module-serialize/releases/tag/3.1.0) - 2021-01-16  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-module-serialize/milestone/8?closed=1)  
    

### Changed

- Update application dependency ([#29](https://github.com/unity-game-framework/ugf-module-serialize/pull/29))  
    - Update dependencies: `com.ugf.application` to `7.1.0` version and `com.ugf.serialize` to `4.0.0` version.

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


